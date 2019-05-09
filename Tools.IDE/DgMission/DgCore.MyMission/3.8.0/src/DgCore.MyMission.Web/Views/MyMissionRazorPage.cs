using Abp.AspNetCore.Mvc.Views;

namespace DgCore.MyMission.Web.Views
{
    public abstract class MyMissionRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyMissionRazorPage()
        {
            LocalizationSourceName = MyMissionConsts.LocalizationSourceName;
        }
    }
}
