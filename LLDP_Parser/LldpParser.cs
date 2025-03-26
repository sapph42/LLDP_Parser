using System.Diagnostics.Eventing.Reader;
using System.Management.Automation;
using Microsoft.Extensions.Logging;

namespace SapphTools.Parsers.Lldp;

public static class LldpParser {
    public static IEnumerable<Tlv> Parse(IEnumerable<byte> bytes) => Parse(bytes, null);
    public static IEnumerable<Tlv> Parse(IEnumerable<byte> bytes, ILogger? Logger) {
        byte[] byteArray = bytes.ToArray();
        return ParseLldp(byteArray, Logger);
    }
    public static byte[]? CollectLldpData() => CollectLLDPData(60, null);
    public static byte[]? CollectLldpData(int collectionWindow) => CollectLLDPData(collectionWindow, null);
    public static byte[]? CollectLLDPData(ILogger? Logger) => CollectLLDPData(60, Logger);
    public static byte[]? CollectLLDPData(int collectionWindow, ILogger? Logger) {
        string sessionName = "LLDP";
        string etlFile = Path.GetTempFileName().Replace(".tmp", ".etl");

        using PowerShell ps = PowerShell.Create();
        ps.AddScript($@"Remove-NetEventSession -Name {sessionName} -ErrorAction SilentlyContinue
New-NetEventSession -Name {sessionName} -LocalFilePath '{etlFile}' -CaptureMode SaveToFile
Add-NetEventPacketCaptureProvider -SessionName {sessionName} -EtherType 0x88CC -TruncationLength 1024 -CaptureType BothPhysicalAndSwitch
Add-NetEventNetworkAdapter -Name (Get-NetAdapter -Physical | Where-Object {{$_.Status -eq 'Up'}} | Select-Object -First 1).Name -PromiscuousMode $true
Start-NetEventSession -Name {sessionName}
Start-Sleep -Seconds {collectionWindow}
Stop-NetEventSession -Name {sessionName}
");
        ps.Invoke();
        if (ps.HadErrors && ps.Streams.Error.Count > 0) {
            Logger?.LogError("LLDPCollect: Error Capturing LLDP packet");
            return null;
        }

        var events = new EventLogReader(new EventLogQuery(etlFile, PathType.FilePath));
        EventRecord record;
        while ((record = events.ReadEvent()) != null) {
            using (record) {
                if (record.Id != 1001)
                    continue;
                if (record.Properties.Count < 4)
                    continue;

                byte[] data = (byte[])record.Properties[3].Value;

                ushort etherType = BitConverter.ToUInt16(new byte[] { data[13], data[12] }, 0);
                if (etherType != 0x88CC)
                    continue;
                string srcMac = BitConverter.ToString(data, 6, 6);
                return data;
            }
        }
        return null;
    }
    private static IEnumerable<Tlv> ParseLldp(byte[] frameData, ILogger? Logger) {
        int offset = 14; //skip Ethernet header
        string? portDesc = null;
        string? systemName = null;
        List<Tlv> tlvRecords = new();
        while (offset < frameData.Length) {
            if (frameData[offset] == 0) {
                tlvRecords.Add(new Tlv(frameData[offset..]));
                break;
            }
            ushort len = (ushort)(Tlv.GetLength(frameData[offset..(offset + 2)]) + 2);
            if (offset + len > frameData.Length) {
                Logger?.LogError("LLDPCollect: Malformed TLV record encountered. Data may be incomplete.");
                break;
            }
            try {
                tlvRecords.Add(new Tlv(frameData[offset..(offset + len)]));
            } catch {
                Logger?.LogError("LLDPCollect: Malformed TLV record encountered. Data may be incomplete.");
                break;
            }
            offset += len;
        }
        Logger?.LogInformation("LLDPCollect: TLV Parsing Complete");
        Logger?.LogInformation("LLDPCollect: TLV Follows");
        foreach (var tlv in tlvRecords) {
            Logger?.LogInformation($"LLPDCollect: {tlv.ToString()}");
        }
        portDesc = tlvRecords.FirstOrDefault(tlv => tlv.Type == TlvType.PortID)?.Data?.ToString();
        systemName = tlvRecords.FirstOrDefault(tlv => tlv.Type == TlvType.SystemName)?.Data?.ToString();
        return tlvRecords;
    }
}
