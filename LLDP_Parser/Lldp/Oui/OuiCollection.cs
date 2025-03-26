using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace SapphTools.Parsers.Lldp.Oui;

public class OuiCollection : List<Oui> {
    public OuiCollection() { }
    public static OuiCollection CreateCollection() {
        using MemoryStream stream = new(Properties.Resource.mac_vendors_export);
        OuiCollection col = new();
        col = JsonSerializer
            .DeserializeAsync<OuiCollection>(
                stream,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            )
            .GetAwaiter()
            .GetResult();
        return col;
    } 
}
