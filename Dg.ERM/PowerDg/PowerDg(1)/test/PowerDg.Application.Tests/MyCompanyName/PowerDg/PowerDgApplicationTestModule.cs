using Volo.Abp.Modularity;

namespace PowerDg
{
    [DependsOn(
        typeof(PowerDgApplicationModule),
        typeof(PowerDgDomainTestModule)
        )]
    public class PowerDgApplicationTestModule : AbpModule
    {

    }
}
