using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DgMission.Configuration;

namespace DgMission.Web.Host.Startup
{
    [DependsOn(
       typeof(DgMissionWebCoreModule))]
    public class DgMissionWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DgMissionWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DgMissionWebHostModule).GetAssembly());
        }
    }
}
