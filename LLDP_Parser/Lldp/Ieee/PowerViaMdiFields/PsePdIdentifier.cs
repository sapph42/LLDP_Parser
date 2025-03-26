using System;

namespace SapphTools.Parsers.Lldp.Ieee.PowerViaMdiFields;

[Flags]
public enum PsePdIdentifier : byte {
    Unk = 0,
    PSE = 1,
    PD  = 2,
}
