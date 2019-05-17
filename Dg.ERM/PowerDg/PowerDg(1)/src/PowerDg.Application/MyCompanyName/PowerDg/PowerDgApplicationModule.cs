using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace PowerDg
{
    [DependsOn(
        typeof(PowerDgDomainModule),
        typeof(PowerDgApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class PowerDgApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<PowerDgApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}
