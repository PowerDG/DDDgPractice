using Volo.Abp;
using Volo.Abp.Modularity;

namespace PowerDg
{
    public abstract class PowerDgTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> 
        where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
