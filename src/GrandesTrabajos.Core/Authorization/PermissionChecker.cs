using Abp.Authorization;
using GrandesTrabajos.Authorization.Roles;
using GrandesTrabajos.Authorization.Users;

namespace GrandesTrabajos.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
