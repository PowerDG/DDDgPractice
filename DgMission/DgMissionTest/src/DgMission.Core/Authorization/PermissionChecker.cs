using Abp.Authorization;
using DgMission.Authorization.Roles;
using DgMission.Authorization.Users;

namespace DgMission.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
