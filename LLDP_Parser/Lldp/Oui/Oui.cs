using System;
using System.Text.Json.Serialization;

#nullable enable
namespace SapphTools.Parsers.Lldp.Oui;
public class Oui {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable IDE1006 // Naming Styles
    public string macPrefix { get; set; }
    public string vendorName { get; set; }
    public bool Private { get; set; }
    public string blockType { get; set; }
    public string lastUpdate { get; set; }
    [JsonIgnore] public DateTime? LastUpdate => DateTime.Parse(lastUpdate);
}
#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
