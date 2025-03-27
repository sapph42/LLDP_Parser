namespace SapphTools.Parsers.Lldp.Types; 
public class PowerViaMdi {
    public object Byte0;
    private readonly PsePdIdentifier PsePdIdentifier;
    private readonly MdiPowerSupport? MdiPowerSupport;
    public PowerPair PowerPair;
    public PowerClass PowerClass;
    public ushort? PowerValue = null;
    public byte[]? VendorExtensions = null;
    public PowerViaMdi(byte[] data) {
        if (data[0] > 3) {
            PsePdIdentifier = (PsePdIdentifier)(data[0] & 0x11);
            MdiPowerSupport = (MdiPowerSupport)data[0];
            Byte0 = MdiPowerSupport;
        } else {
            PsePdIdentifier = (PsePdIdentifier)data[0];
            Byte0 = PsePdIdentifier;
        }
        PowerPair = (PowerPair)data[1];
        PowerClass = (PowerClass)data[2];
        if (data.Length >= 4) {
            PowerValue = BinaryPrimitives.ReadUInt16BigEndian(data.AsSpan()[3..5]);
        }
        if (data.Length >= 6) {
            VendorExtensions = data[5..];
        }
    }
    public override string ToString() {
        return $"MDI Power Support: {Byte0}; PowerPair: {PowerPair}; PowerClass: {PowerClass}; PowerValue: {PowerValue}; PowerExtensions: {VendorExtensions}";
    }
}
