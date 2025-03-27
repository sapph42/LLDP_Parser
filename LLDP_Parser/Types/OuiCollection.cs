using System.Text.Json;

namespace SapphTools.Parsers.Lldp.Types;
public class OuiCollection : List<Oui> {
    private readonly static JsonSerializerOptions _options = new() { PropertyNameCaseInsensitive = true };
    public OuiCollection() { }
    public static OuiCollection CreateCollection() {
        using MemoryStream stream = new(Properties.Resources.mac_vendors_export);
        return JsonSerializer.Deserialize<OuiCollection>(stream, _options) ?? [];
    } 
}
