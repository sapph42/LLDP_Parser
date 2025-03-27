namespace SapphTools.Parsers.Lldp.Types;
public enum TlvType : byte {
    EndOfLldpdu          = 0,
    ChassisID            = 1,
    PortID               = 2,
    TTL                  = 3,
    PortDescription      = 4,
    SystemName           = 5,
    SystemDesc           = 6,
    SystemCapabilities   = 7,
    ManagementAddress    = 8,
    OrganizationSpecific = 127,
    UnknownOrInvalid     = 255
}
