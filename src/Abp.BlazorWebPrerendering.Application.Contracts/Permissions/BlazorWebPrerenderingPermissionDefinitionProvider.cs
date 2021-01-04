using Abp.BlazorWebPrerendering.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.BlazorWebPrerendering.Permissions
{
    public class BlazorWebPrerenderingPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BlazorWebPrerenderingPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(BlazorWebPrerenderingPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BlazorWebPrerenderingResource>(name);
        }
    }
}
