using Abp.Authorization;
using PowerDg.ERM.Authorization.Roles;
using PowerDg.ERM.Authorization.Users;

namespace PowerDg.ERM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
