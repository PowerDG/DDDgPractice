using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace PowerDg
{
    [DependsOn(
        typeof(PowerDgApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class PowerDgHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "PowerDg";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(PowerDgApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
