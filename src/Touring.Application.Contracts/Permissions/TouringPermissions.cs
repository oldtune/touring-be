using Volo.Abp.Reflection;

namespace Touring.Permissions;

public class TouringPermissions
{
    public const string GroupName = "Touring";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(TouringPermissions));
    }
}
