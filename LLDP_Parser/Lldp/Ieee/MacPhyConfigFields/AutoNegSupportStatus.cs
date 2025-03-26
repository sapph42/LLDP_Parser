using System;

namespace SapphTools.Parsers.Lldp.Ieee.MacPhyConfigFields;

[Flags]
public enum AutoNegSupportStatus {
    NotSupported = 0,
    Supported    = 1,
    Enabled      = 2,
}
