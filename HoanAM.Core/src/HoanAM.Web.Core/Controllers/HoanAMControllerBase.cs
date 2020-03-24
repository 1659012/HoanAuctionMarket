using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HoanAM.Controllers
{
    public abstract class HoanAMControllerBase: AbpController
    {
        protected HoanAMControllerBase()
        {
            LocalizationSourceName = HoanAMConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
