using Abp.Authorization;
using boilerplatetest.Authorization.Roles;
using boilerplatetest.Authorization.Users;

namespace boilerplatetest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
