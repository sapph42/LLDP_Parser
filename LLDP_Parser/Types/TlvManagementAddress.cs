using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace SapphTools.Parsers.Lldp.Types;
public class TlvManagementAddress(
    byte addressLength,
    byte addressSubtype,
    byte[] address,
    byte interfaceSubtype,
    uint interfaceNumber,
    byte oidLength,
    byte[]? oid) {
    public byte AddressLength = addressLength;
    public AddressType AddressSubtype = (AddressType)addressSubtype;
    public object Address = addressSubtype switch {
        1 or 2 => new IPAddress(address),
        6 => new PhysicalAddress(address),
        20 => Encoding.UTF8.GetString(address),
        _ => address,
    };
    public InterfaceType InterfaceSubtype = (InterfaceType)interfaceSubtype;
    public uint InterfaceNumber = interfaceNumber;
    public ushort OidLength = oidLength;
    public byte[]? Oid = oid;

    public new string ToString() {
        return Address.ToString() ?? "";
    }
}
