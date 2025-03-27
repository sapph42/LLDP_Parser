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

|   |   |
|---|---|
| CollectLlpdData()                  | Returns a `byte` array containing a captured LLDP frame, or `null` if no frame was captured. |
| CollectLlpdData(Int32)             | Returns a `byte` array containing a captured LLDP frame after the specified capture duration in seconds. |
| CollectLldpData(ILogger?)          | Returns a `byte` array containing a captured LLDP frame, optionally logging capture status. |
| CollectLldpData(Int32, ILogger?)   | Returns a `byte` array containing a captured LLDP frame after the specified duration, with optional logging. |
| Parse(IEnumerable<Byte>)           | Returns a list of `Tlv` instances parsed from the provided byte sequence. |
| Parse(IEnumerable<Byte>, ILogger?) | Returns a list of `Tlv` instances parsed from the provided byte sequence, optionally logging errors and diagnostics. |


### Types and method descriptions coming soon
