using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DgCore.MyMission.Web.Startup;
namespace DgCore.MyMission.Web.Tests
{
    [DependsOn(
        typeof(MyMissionWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MyMissionWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyMissionWebTestModule).GetAssembly());
        }
    }
}