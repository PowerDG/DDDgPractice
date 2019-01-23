using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DgMission.Controllers
{
    public abstract class DgMissionControllerBase: AbpController
    {
        protected DgMissionControllerBase()
        {
            LocalizationSourceName = DgMissionConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
