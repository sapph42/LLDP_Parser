namespace SapphTools.Parsers.Lldp.Types;

[Flags]
public enum PsePdIdentifier : byte {
    Unk = 0,
    PSE = 1,
    PD  = 2,
}
