using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GetDoIt.Controllers
{
    public abstract class GetDoItControllerBase: AbpController
    {
        protected GetDoItControllerBase()
        {
            LocalizationSourceName = GetDoItConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
