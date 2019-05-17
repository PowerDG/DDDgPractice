using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace PowerDg
{
    [DependsOn(
        typeof(PowerDgApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class PowerDgHttpApiModule : AbpModule
    {
        
    }
}
