namespace SapphTools.Parsers.Lldp.Types;
public enum PortSubType : byte {
    InterfaceAlias = 1,
    PortComponent  = 2,
    MacAddress     = 3,
    NetworkAddress = 4,
    InterfaceName  = 5,
    AgentCircuitId = 6,
    Local          = 7
}
