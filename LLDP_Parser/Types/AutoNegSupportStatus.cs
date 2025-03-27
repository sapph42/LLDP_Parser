namespace SapphTools.Parsers.Lldp.Types;

[Flags]
public enum AutoNegSupportStatus : byte {
    NotSupported = 0,
    Supported    = 1,
    Enabled      = 2,
}
