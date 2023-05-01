using SincomYazilim.WebOnMuhasebe.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SincomYazilim.WebOnMuhasebe.Permissions;

public class WebOnMuhasebePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WebOnMuhasebePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(WebOnMuhasebePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WebOnMuhasebeResource>(name);
    }
}
