using System;

namespace SapphTools.Parsers.Lldp.Ieee.LinkAggFields;

[Flags]
public enum AggStatus : byte {
    Supported = 1,
    Enabled   = 2
}
