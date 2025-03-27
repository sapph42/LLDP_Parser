namespace SapphTools.Parsers.Lldp.Types; 
public enum PowerClass : byte {
    [Description("Legacy (< 13W)")]
    Undef        = 0,

    [Description("802.3af Low (4W)")]
    Low          = 1,

    [Description("802.3af Medium (7W)")]
    Medium       = 2,

    [Description("802.3af High (15.4W)")]
    High         = 3,

    [Description("802.3at PoE+ (30W)")]
    PoEPlus      = 4,

    [Description("802.3bt 4-Pair (45W)")]
    PoE4Pair     = 5,

    [Description("802.bt 4-Pair High (60W)")]
    HighPoE4Pair = 6,

    [Description("802.bt Ultra (75W)")]
    UltraPoE     = 7,

    [Description("802.bt Max (90W)")]
    Max          = 8
}
