using Abp.Authorization;
using HoanAM.Authorization.Roles;
using HoanAM.Authorization.Users;

namespace HoanAM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
