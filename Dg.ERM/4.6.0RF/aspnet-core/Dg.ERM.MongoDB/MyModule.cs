using Volo.Abp.MongoDB;
using Volo.Abp.Modularity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Dg.ERM.MongoDB
{
    [DependsOn(typeof(AbpMongoDbModule))]
    public class MyModule : AbpModule
    {
        //...
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<MyDbContext>();

            //...
        }
    }
}
