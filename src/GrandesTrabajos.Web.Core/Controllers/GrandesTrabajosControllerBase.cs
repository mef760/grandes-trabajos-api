using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GrandesTrabajos.Controllers
{
    public abstract class GrandesTrabajosControllerBase: AbpController
    {
        protected GrandesTrabajosControllerBase()
        {
            LocalizationSourceName = GrandesTrabajosConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
