namespace SapphTools.Parsers.Lldp.Types;

[Flags]
public enum MdiPowerSupport : byte {
    None          = 0,
    Pse           = 1,
    Pd            = 2,
    Supported     = 4,
    Enabled       = 8,
    SourcePrimary = 16,
    SourceBackup  = 32,
    PriorityCrit  = 64,
    PriorityHigh  = 128,
    PriorityLow   = PriorityCrit | PriorityHigh,
}
