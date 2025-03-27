using System.Text.Json.Serialization;

namespace SapphTools.Parsers.Lldp.Types;
public class Oui {
    public required string MacPrefix { get; set; }
    public required string VendorName { get; set; }
    public required bool Private { get; set; }
    public required string BlockType { get; set; }

    [JsonInclude]
    [JsonPropertyName("lastUpdate")]
    public required string LastUpdateRaw { get; init; }

    [JsonIgnore]
    public DateTime? LastUpdate => DateTime.TryParse(LastUpdateRaw, out var dt) ? dt : null;
}