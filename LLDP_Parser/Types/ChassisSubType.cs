namespace SapphTools.Parsers.Lldp.Types;
public enum ChassisSubType :byte {
    ChassisComponent    = 1,
    InterfaceAlias      = 2,
    PortComponent       = 3,
    MacAddress          = 4,
    NetworkAddress      = 5,
    InterfaceName       = 6,
    LocallyAssigned     = 7
}