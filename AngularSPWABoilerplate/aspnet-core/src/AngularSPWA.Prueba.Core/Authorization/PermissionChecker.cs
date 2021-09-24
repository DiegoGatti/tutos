using Abp.Authorization;
using AngularSPWA.Prueba.Authorization.Roles;
using AngularSPWA.Prueba.Authorization.Users;

namespace AngularSPWA.Prueba.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
