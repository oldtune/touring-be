using Touring.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Touring.Permissions;

public class TouringPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TouringPermissions.GroupName, L("Permission:Touring"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TouringResource>(name);
    }
}
