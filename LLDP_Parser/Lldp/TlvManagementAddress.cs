using System.Net;
using System.Net.NetworkInformation;
using System.Text;

#nullable enable
namespace SapphTools.Parsers.Lldp;
public class TlvManagementAddress {
    public byte AddressLength;
    public AddressType AddressSubtype;
    public object Address;
    public InterfaceType InterfaceSubtype;
    public uint InterfaceNumber;
    public ushort OidLength;
    public byte[]? Oid;

    public TlvManagementAddress(
        byte addressLength,
        byte addressSubtype,
        byte[] address,
        byte interfaceSubtype,
        uint interfaceNumber,
        byte oidLength,
        byte[]? oid) {
        AddressLength = addressLength;
        AddressSubtype = (AddressType)addressSubtype;
        switch (addressSubtype) {
            case 1:
            case 2:
                Address = new IPAddress(address);
                break;
            case 6:
                Address = new PhysicalAddress(address);
                break;
            case 20:
                Address = Encoding.UTF8.GetString(address);
                break;
            default:
                Address = address;
                break;
        }
        InterfaceSubtype = (InterfaceType)interfaceSubtype;
        InterfaceNumber = interfaceNumber;
        OidLength = oidLength;
        Oid = oid;
    }
    public new string ToString() {
        return Address.ToString();
    }
}
