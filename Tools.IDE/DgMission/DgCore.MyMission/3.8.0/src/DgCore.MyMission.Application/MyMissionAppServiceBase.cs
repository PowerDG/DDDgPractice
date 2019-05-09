using Abp.Application.Services;

namespace DgCore.MyMission
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyMissionAppServiceBase : ApplicationService
    {
        protected MyMissionAppServiceBase()
        {
            LocalizationSourceName = MyMissionConsts.LocalizationSourceName;
        }
    }
}