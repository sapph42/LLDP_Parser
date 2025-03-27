namespace SapphTools.Parsers.Lldp.Types;

[Flags]
public enum Capability : ushort {
    Other = 0x0001,
    Repeater = 0x0002,
    Bridge = 0x0004,
    WlanAp = 0x0008,
    Router = 0x0010,
    Telephone = 0x0020,
    Docsis = 0x0040,
    StationOnly = 0x0080,
    CvlanComp = 0x0100,
    SvlanComp = 0x0200,
    Tpmr = 0x0400
}
