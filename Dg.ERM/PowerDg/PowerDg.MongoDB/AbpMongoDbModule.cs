using Volo.Abp.MongoDB;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using PowerDg.MongoDB;

namespace MyCompany.MyProject
{
    [DependsOn(typeof(AbpMongoDbModule))]
    public class MyModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<MyDbContext>();
          
            //...
        }
    }
}
