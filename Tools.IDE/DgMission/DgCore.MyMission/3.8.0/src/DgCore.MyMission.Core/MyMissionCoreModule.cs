using Abp.Modules;
using Abp.Reflection.Extensions;
using DgCore.MyMission.Localization;

namespace DgCore.MyMission
{
    public class MyMissionCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyMissionLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyMissionCoreModule).GetAssembly());
        }
    }
}