using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace boilerplatetest.Controllers
{
    public abstract class boilerplatetestControllerBase: AbpController
    {
        protected boilerplatetestControllerBase()
        {
            LocalizationSourceName = boilerplatetestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
