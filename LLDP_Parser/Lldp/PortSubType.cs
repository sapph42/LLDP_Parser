using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapphTools.Parsers.Lldp;

public enum PortSubType {
    InterfaceAlias = 1,
    PortComponent  = 2,
    MacAddress     = 3,
    NetworkAddress = 4,
    InterfaceName  = 5,
    AgentCircuitId = 6,
    Local          = 7
}
