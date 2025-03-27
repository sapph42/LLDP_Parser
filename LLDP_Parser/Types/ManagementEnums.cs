namespace SapphTools.Parsers.Lldp.Types;
public enum AddressType : byte {
    Ipv4 = 1,
    Ipv6 = 2,
    Mac = 6,
    DNS = 20
}
public enum InterfaceType : byte {
    ifIndex = 1,
    SystemPortNumber = 2
}
