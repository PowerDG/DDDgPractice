using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DgMission.Authorization;

namespace DgMission
{
    [DependsOn(
        typeof(DgMissionCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DgMissionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DgMissionAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DgMissionApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
