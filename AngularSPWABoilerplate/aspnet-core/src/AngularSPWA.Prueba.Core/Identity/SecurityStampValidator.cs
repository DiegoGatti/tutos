using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using AngularSPWA.Prueba.Authorization.Roles;
using AngularSPWA.Prueba.Authorization.Users;
using AngularSPWA.Prueba.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace AngularSPWA.Prueba.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
