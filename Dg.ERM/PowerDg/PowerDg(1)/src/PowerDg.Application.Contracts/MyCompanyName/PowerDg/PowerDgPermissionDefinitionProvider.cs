using PowerDg.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PowerDg
{
    public class PowerDgPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(PowerDgPermissions.GroupName, L("Permission:PowerDg"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PowerDgResource>(name);
        }
    }
}