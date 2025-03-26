using System;
using System.Buffers.Binary;
using System.Linq;
using SapphTools.Parsers.Lldp.Ieee;
using SapphTools.Parsers.Lldp.Oui;

#nullable enable
namespace SapphTools.Parsers.Lldp;
public class OrganizationSpecific {
    public Oui.Oui? Oui { get; set; }
    public byte[] OuiBytes { get; set; }
    public object Subtype { get; set; }
    public byte[] Payload { get; set; } = Array.Empty<byte>();
    public object Data { get; set; }
    private string formattedOiuBytes;
    public OrganizationSpecific(byte[] oui, byte subtype, byte[] payload, OuiCollection ouiCollection) {
        formattedOiuBytes = $"{oui[0]:X2}:{oui[1]:X2}:{oui[2]:X2}";
        Oui = ouiCollection.Where(o => o.macPrefix == formattedOiuBytes).FirstOrDefault();
        OuiBytes = oui;
        if (Oui is not null && Oui.macPrefix == "00:12:0F" && Enum.IsDefined(typeof(Ieee8023Subtypes), subtype)) {
            Subtype = (Ieee8023Subtypes)subtype;
        } else {
            Subtype = subtype;
        }
        Payload = payload;
        Data = Payload;
        ConstructData();
    }
    private void ConstructData() {
        if (Subtype is Ieee8023Subtypes subtypes) {
            switch (subtypes) {
                case Ieee8023Subtypes.MacPhyConfigStatus:
                    if (Payload.Length == 5)
                        Data = new MacPhyConfigStatus(Payload);
                    break;
                case Ieee8023Subtypes.PowerViaMdi:
                    if (Payload.Length >= 3)
                        Data = new PowerViaMdi(Payload);
                    break;
                case Ieee8023Subtypes.LinkAggregation:
                    if (Payload.Length == 5)
                        Data = new LinkAgg(Payload);
                    break;
                case Ieee8023Subtypes.MaxFrameSize:
                    if (Payload.Length >= 4)
                        Data = BinaryPrimitives.ReadUInt16BigEndian(Payload);
                    break;
            }
        }
    }
    public new string ToString() {
        if (Oui is not null) {
            if (!string.IsNullOrWhiteSpace(Oui.vendorName))
                if (Oui.macPrefix == "00:12:0F") {
                    return $"{Oui.vendorName}; Data: {Data}";
                }
                return $"{Oui.vendorName} {formattedOiuBytes}";
        }
        return formattedOiuBytes;
    }

}