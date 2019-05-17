using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using PowerDg.Localization;

namespace PowerDg
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class PowerDgDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Add<PowerDgResource>("en");
            });
        }
    }
}
