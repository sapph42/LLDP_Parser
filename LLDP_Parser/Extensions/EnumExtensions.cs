using System.Reflection;

namespace SapphTools.Parsers.Lldp.Extensions;
internal static class EnumExtensions {
    public static string ToDescription(this Enum value) {
        var type = value.GetType();
        var member = type.GetMember(value.ToString()).FirstOrDefault();
        if (member is not null) {
            var attr = member.GetCustomAttribute<DescriptionAttribute>();
            if (attr is not null)
                return attr.Description;
        }
        return value.ToString();
    }
}
