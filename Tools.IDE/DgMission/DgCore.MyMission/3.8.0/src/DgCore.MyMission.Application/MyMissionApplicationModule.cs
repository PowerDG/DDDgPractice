using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DgCore.MyMission
{
    [DependsOn(
        typeof(MyMissionCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyMissionApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyMissionApplicationModule).GetAssembly());
        }
    }
}