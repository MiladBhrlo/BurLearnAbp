using BurLearn.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace BurLearn.Permissions;

public class BurLearnPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BurLearnPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(BurLearnPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BurLearnPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BurLearnPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BurLearnPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BurLearnPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BurLearnResource>(name);
    }
}
