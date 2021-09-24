using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AngularSPWA.Prueba.Controllers
{
    public abstract class PruebaControllerBase: AbpController
    {
        protected PruebaControllerBase()
        {
            LocalizationSourceName = PruebaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
