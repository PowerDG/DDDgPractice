using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DgCore.MyMission.Configuration;
using DgCore.MyMission.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace DgCore.MyMission.Web.Startup
{
    [DependsOn(
        typeof(MyMissionApplicationModule), 
        typeof(MyMissionEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MyMissionWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyMissionWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MyMissionConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MyMissionNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MyMissionApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyMissionWebModule).GetAssembly());
        }
    }
}