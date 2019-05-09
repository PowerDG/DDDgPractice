using Abp.AspNetCore.Mvc.Controllers;

namespace DgCore.MyMission.Web.Controllers
{
    public abstract class MyMissionControllerBase: AbpController
    {
        protected MyMissionControllerBase()
        {
            LocalizationSourceName = MyMissionConsts.LocalizationSourceName;
        }
    }
}