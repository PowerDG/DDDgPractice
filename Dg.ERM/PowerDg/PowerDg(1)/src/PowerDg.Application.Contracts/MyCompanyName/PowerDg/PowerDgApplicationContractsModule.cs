using Microsoft.Extensions.DependencyInjection;
using PowerDg.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace PowerDg
{
    [DependsOn(
        typeof(PowerDgDomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class PowerDgApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<PowerDgApplicationContractsModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<PowerDgResource>()
                    .AddVirtualJson("/MyCompanyName/PowerDg/Localization/ApplicationContracts");
            });
        }
    }
}
