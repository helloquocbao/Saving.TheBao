using Abp.Authorization;
using GetDoIt.Authorization.Roles;
using GetDoIt.Authorization.Users;

namespace GetDoIt.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
