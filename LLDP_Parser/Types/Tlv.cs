using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace SapphTools.Parsers.Lldp.Types {
    public class Tlv {
        private static OuiCollection ouis = [];
        public TlvType Type { get; set; }
        public object? Subtype { get; set; }
        public ushort Length { get; set; }
        public byte[] RawPayload { get; set; }
        public object? Data;
        public Tlv(byte[] tlvBytes) {
            Type = (TlvType)(tlvBytes[0] >> 1); //First 7 bits
            if (Type == TlvType.EndOfLldpdu) {
                RawPayload = [];
                Data = null;
                Length = 0;
                return;
            }
            Length = GetLength(tlvBytes[0..2]);
            switch (Type) {
                case TlvType.EndOfLldpdu:
                    RawPayload = [];
                    Data = null;
                    break;
                case TlvType.ChassisID:
                    RawPayload = tlvBytes[3..];
                    ParseChassisSubtype(tlvBytes[2]);
                    break;
                case TlvType.PortID:
                    RawPayload = tlvBytes[3..];
                    ParsePortSubType(tlvBytes[2]);
                    break;
                case TlvType.TTL:
                    if (Length != 2)
                        throw new ArgumentOutOfRangeException($"TlvRecord indicates {Type}, Length was {Length} bytes");
                    RawPayload = tlvBytes[2..];
                    Data = BinaryPrimitives.ReadUInt16BigEndian(RawPayload);
                    break;
                case TlvType.PortDescription:
                case TlvType.SystemName:
                case TlvType.SystemDesc:
                    RawPayload = tlvBytes[2..];
                    Data = Encoding.ASCII.GetString(RawPayload).TrimEnd('\0');
                    break;
                case TlvType.SystemCapabilities:
                    RawPayload = tlvBytes[2..];
                    ushort system = BinaryPrimitives.ReadUInt16BigEndian(RawPayload.AsSpan()[0..2]);
                    ushort enabled = BinaryPrimitives.ReadUInt16BigEndian(RawPayload.AsSpan()[2..]);
                    Capability systemCap = (Capability)system;
                    Capability enabledCap = (Capability)enabled;
                    Data = new Capabilities() { System = systemCap, Enabled = enabledCap };
                    break;
                case TlvType.ManagementAddress:
                    RawPayload = tlvBytes[2..];
                    byte maLength = RawPayload[0];
                    byte maSubtype = RawPayload[1];
                    int offset = maLength + 1;
                    byte[] maAddress = RawPayload[2..offset];
                    byte iSubtype = RawPayload[offset++];
                    uint intNum = BinaryPrimitives.ReadUInt32BigEndian(RawPayload.AsSpan()[offset..(offset + 4)]);
                    offset += 4;
                    byte olen = RawPayload[offset++];
                    byte[]? oid = olen > 0 ? RawPayload[offset..(offset+olen)] : null;
                    Data = new TlvManagementAddress(maLength, maSubtype, maAddress, iSubtype, intNum, olen, oid);
                    break;
                case TlvType.OrganizationSpecific:
                    RawPayload = tlvBytes[2..];
                    if (ouis.Count == 0)
                        ouis = OuiCollection.CreateCollection();
                    Data = new OrganizationSpecific(RawPayload[0..3], RawPayload[3], RawPayload[4..], ouis);
                    break;
                default:
                    Type = TlvType.UnknownOrInvalid;
                    RawPayload = tlvBytes[2..];
                    Data = RawPayload;
                    break;
            }
        }
        public new string ToString() {
            StringBuilder sb = new();
            sb.Append("TLV Type: ");
            sb.Append(Type);
            sb.Append("; Data: ");
            if (Data is null) {
                sb.Append("{null}");
                return sb.ToString();
            }
            switch (Data.GetType()) {
                case Type macType when macType == typeof(PhysicalAddress):
                    sb.Append($"MAC Address: {Data}");
                    break;
                case Type ipType when ipType == typeof(IPAddress):
                    sb.Append($"IPAddress: {Data}");
                    break;
                case Type ushortType when ushortType == typeof(ushort):
                case Type strType when strType == typeof(string):
                    sb.Append(Data);
                    break;
                case Type capType when capType == typeof(Capabilities):
                    sb.Append($"Enabled Capabilities: {((Capabilities)Data).Enabled}");
                    break;
                case Type orgType when orgType == typeof(OrganizationSpecific):
                    sb.Append($"OrganizationSpecific: {((OrganizationSpecific)Data).ToString()}");
                    break;
                case Type mgtType when mgtType == typeof(TlvManagementAddress):
                    sb.Append($"ManagementAddress: {((TlvManagementAddress)Data).ToString()}");
                    break;
                case Type byteType when byteType == typeof(byte[]):
                    sb.Append("byte[]");
                    break;
            }
            return sb.ToString();
        }
        public static ushort GetLength(byte[] typeAndLength) {
            if (typeAndLength.Length != 2)
                throw new ArgumentOutOfRangeException($"Only two bytes may be provided, {nameof(typeAndLength)} was {typeAndLength.Length}");
            const ushort typeMask = 0x01FF;
            return (ushort)(BinaryPrimitives.ReadUInt16BigEndian(typeAndLength) & typeMask);
        }
        private void ParseChassisSubtype(byte subtype) {
            switch (subtype) {
                case 1:
                case 3:
                    Subtype = (ChassisSubType)subtype;
                    Data = RawPayload;
                    break;
                case 2:
                case 6:
                case 7:
                    Subtype = (ChassisSubType)subtype;
                    Data = Encoding.ASCII.GetString(RawPayload).TrimEnd('\0');
                    break;
                case 4:
                    Subtype = (ChassisSubType)subtype;
                    if (RawPayload!.Length != 6)
                        throw new ArgumentOutOfRangeException($"TlvRecord indicates {Type} {Subtype}, Length was {Length} bytes");
                    Data = new PhysicalAddress(RawPayload);
                    break;
                case 5:
                    Subtype = (ChassisSubType)subtype;
                    if (RawPayload![0] > 2)
                        throw new ArgumentOutOfRangeException($"TlvRecord indicates {Type} {Subtype}, with an unsupported Address Family");
                    RawPayload = RawPayload![1..];
                    if (RawPayload.Length != 4 && RawPayload.Length != 16)
                        throw new ArgumentOutOfRangeException($"TlvRecord indicates {Type} {Subtype}, Length was {Length} bytes");
                    Data = new IPAddress(RawPayload);
                    break;
            }
        }
        private void ParsePortSubType(byte subtype) {
            switch (subtype) {
                case 2:
                    Subtype = (PortSubType)subtype;
                    Data = RawPayload;
                    break;
                case 1:
                case 5:
                case 7:
                    Subtype = (PortSubType)subtype;
                    Data = Encoding.ASCII.GetString(RawPayload).TrimEnd('\0');
                    break;
                case 3:
                    Subtype = (PortSubType)subtype;
                    if (RawPayload!.Length != 6)
                        throw new ArgumentOutOfRangeException($"TlvRecord indicates {Type} {Subtype}, Length was {Length} bytes");
                    Data = new PhysicalAddress(RawPayload);
                    break;
                case 4:
                    Subtype = (PortSubType)subtype;
                    if (RawPayload!.Length != 4 && RawPayload.Length != 16)
                        throw new ArgumentOutOfRangeException($"TlvRecord indicates {Type} {Subtype}, Length was {Length} bytes");
                    Data = new IPAddress(RawPayload);
                    break;
                case 6:
                    Subtype = (PortSubType)subtype;
                    Data = TryCircuitIdInterpretation(RawPayload!);
                    break;
            }
        }
        private static object TryCircuitIdInterpretation(byte[] data) {
            return data.All(b => b >= 0x20 && b <= 0x7E)
                ? Encoding.ASCII.GetString(data)
                : data;
        }
    }
}
