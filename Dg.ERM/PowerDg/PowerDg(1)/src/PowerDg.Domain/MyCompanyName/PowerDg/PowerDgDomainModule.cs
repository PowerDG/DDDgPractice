using Microsoft.Extensions.DependencyInjection;
using PowerDg.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace PowerDg
{
    [DependsOn(
        typeof(PowerDgDomainSharedModule)
        )]
    public class PowerDgDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<PowerDgDomainModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Get<PowerDgResource>().AddVirtualJson("/MyCompanyName/PowerDg/Localization/Domain");
            });

            Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("PowerDg", typeof(PowerDgResource));
            });
        }
    }
}
