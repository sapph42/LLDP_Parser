using Logon.Classes.Extensions;
using SapphTools.Parsers.Lldp.Ieee.MacPhyConfigFields;
using System.Buffers.Binary;

namespace SapphTools.Parsers.Lldp.Ieee;
public class MacPhyConfigStatus {
    public AutoNegSupportStatus AutoNegSupportStatus { get; set; }
    public AdvCapabilities AdvCapabilities { get; set; }
    public MauType MauType { get; set; }
    public MacPhyConfigStatus(byte[] data) {
        AutoNegSupportStatus = (AutoNegSupportStatus)data[0];
        ushort caps = BinaryPrimitives.ReadUInt16BigEndian(data[1..3]);
        caps = (ushort)((caps & 0x01FF) | ((caps & 0xFE00) != 0 ? 0x200 : 0)); // Flatten 1s in bits 9-16 to bit 9
        AdvCapabilities = (AdvCapabilities)caps;
        ushort mau = BinaryPrimitives.ReadUInt16BigEndian(data[3..5]);
        mau = (ushort)((mau >= 227) ? 0x1 : mau);
        MauType = (MauType)mau;
    }
    public new string ToString() {
        return $"AutoNegotiation: {AutoNegSupportStatus}; AdvancedCapabilities: {AdvCapabilities}; MAU Type: {MauType.ToDescription()}";
    }
}

