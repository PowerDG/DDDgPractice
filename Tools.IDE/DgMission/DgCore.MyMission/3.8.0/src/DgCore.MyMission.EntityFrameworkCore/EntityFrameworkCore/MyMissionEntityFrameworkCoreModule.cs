using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DgCore.MyMission.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyMissionCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyMissionEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyMissionEntityFrameworkCoreModule).GetAssembly());
        }
    }
}