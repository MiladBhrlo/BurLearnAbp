using Volo.Abp.Reflection;

namespace Cource.Permissions;

public class CourcePermissions
{
    public const string GroupName = "Cource";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CourcePermissions));
    }
}
