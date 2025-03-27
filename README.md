# LldpParser Class

## Definition

Namespace: SapphTools.Parsers.Lldp  
Assemblies: SapphTools.Parsers.Lldp.dll  
Source: [LldpParser.cs](LLDP_Parser/LldpParser.cs)

Provides static methods for reading LLDP and parsing LLDP frames (historical or live capture).

```csharp
public static class LldpParser
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-9.0) → LldpParser

## Example

```csharp
using SapphTools.Parsers.Lldp;
using System.Collections.Generic;

namespace LldpClassCS
{
    class ReadAndParseLldpSample
    {
        bate[]? rawLldpFrame = CollectLldpData();
        if (rawLldpFrame is not null)
            List<Tlv> tlvData = Parse(rawLldpFrame);
        Console.WriteLine("The TLV Type of the first TLV reocrd is" tlvData[0].TlvType.ToString());
    }
}
```
## Methods

| CollectLlpdData()                  | Returns a `byte` array of a captured LLDP frame, or `null` if no frame was captured. |
|------------------------------------|--------------------------------------------------------------------------------------|
| CollectLlpdData(Int32)             | Returns a `byte` array of a captured LLDP frame, or `null` if no frame was captured. |
| CollectLldpData(ILogger?)          | Returns a `byte` array of a captured LLDP frame, or `null` if no frame was captured. |
| CollectLldpData(Int32, ILogger?)   | Returns a `byte` array of a captured LLDP frame, or `null` if no frame was captured. |
| Parse(IEnumerable<Byte>)           | Returns a `List` of `Tlv` instances representing parsed TLV records from `byte` array. |
| Parse(IEnumerable<Byte>, ILogger?) | Returns a `List` of `Tlv` instances representing parsed TLV records from `byte` array. |


### Types and method descriptions coming soon
