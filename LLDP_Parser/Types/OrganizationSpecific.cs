namespace SapphTools.Parsers.Lldp.Types;
public class OrganizationSpecific {
    public Oui? Oui;
    public byte[] OuiBytes;
    public object Subtype;
    public byte[] Payload = [];
    public object Data;
    private readonly string formattedOiuBytes;
    public OrganizationSpecific(byte[] oui, byte subtype, byte[] payload, OuiCollection ouiCollection) {
        formattedOiuBytes = $"{oui[0]:X2}:{oui[1]:X2}:{oui[2]:X2}";
        Oui = ouiCollection.Where(o => o.MacPrefix == formattedOiuBytes).FirstOrDefault();
        OuiBytes = oui;
        if (Oui is not null && Oui.MacPrefix == "00:12:0F" && Enum.IsDefined(typeof(Ieee8023Subtypes), subtype)) {
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
    public override string ToString() {
        if (Oui is not null) {
            if (!string.IsNullOrWhiteSpace(Oui.VendorName))
                if (Oui.MacPrefix == "00:12:0F") {
                    return $"{Oui.VendorName}; Data: {Data}";
                }
                return $"{Oui.VendorName} {formattedOiuBytes}";
        }
        return formattedOiuBytes;
    }

}