using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using AngularSPWA.Prueba.Authorization;
using AngularSPWA.Prueba.Authorization.Roles;
using AngularSPWA.Prueba.Authorization.Users;
using AngularSPWA.Prueba.Editions;
using AngularSPWA.Prueba.MultiTenancy;

namespace AngularSPWA.Prueba.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
