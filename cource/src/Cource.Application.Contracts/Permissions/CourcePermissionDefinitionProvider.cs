using Cource.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Cource.Permissions;

public class CourcePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CourcePermissions.GroupName, L("Permission:Cource"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CourceResource>(name);
    }
}
