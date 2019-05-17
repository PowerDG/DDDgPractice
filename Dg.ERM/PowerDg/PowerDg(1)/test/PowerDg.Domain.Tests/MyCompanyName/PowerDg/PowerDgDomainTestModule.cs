using PowerDg.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PowerDg
{
    [DependsOn(
        typeof(PowerDgEntityFrameworkCoreTestModule)
        )]
    public class PowerDgDomainTestModule : AbpModule
    {
        
    }
}
