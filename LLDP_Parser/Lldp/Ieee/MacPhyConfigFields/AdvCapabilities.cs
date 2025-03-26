using System;

namespace SapphTools.Parsers.Lldp.Ieee.MacPhyConfigFields;

[Flags]
public enum AdvCapabilities : ushort {
    Unk_None          = 0,
    TenBaseT          = 1,
    TenBaseTDup       = 2,
    HundredBaseTx     = 4,
    HundredBaseTxDup  = 8,
    HundredBaseT4     = 16,
    Pause             = 32,
    AsymPause         = 64,
    GigBaseX          = 128,
    GigBaseXDup       = 256,
    Other             = 512
}
