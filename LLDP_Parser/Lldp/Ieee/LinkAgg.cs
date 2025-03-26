using System.Buffers.Binary;
using SapphTools.Parsers.Lldp.Ieee.LinkAggFields;

namespace SapphTools.Parsers.Lldp.Ieee;

public class LinkAgg {
    public AggStatus AggStatus { get; set; } = 0;
    public uint? AggPortID { get; set; }
    public LinkAgg(byte[] data) {
        AggStatus = (AggStatus)data[0];
        AggPortID = BinaryPrimitives.ReadUInt32BigEndian(data[1..5]);
        AggPortID = AggPortID == 0 ? null : AggPortID;
    }
    public new string ToString() {
        return $"Aggregation Status: {AggStatus}; Aggregation PortID: {(AggPortID is null ? "null" : AggPortID)}";
    }
}
