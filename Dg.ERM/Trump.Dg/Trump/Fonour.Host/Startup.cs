using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fonour.Application;
using Fonour.EntityFrameworkCore.FonourDbContexts;
using Fonour.EntityFrameworkCore.Repositories;
//using Fonour.EntityFrameworkCore.FonourDbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Fonour.Host
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public IConfigurationRoot Configuration2 { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //获取数据库连接字符串
            var sqlConnectionString = Configuration.GetConnectionString("Default");

            //添加数据上下文
            //services.AddDbContext<FonourDbContext>(options =>
            //    options.UseNpgsql(sqlConnectionString)
            //);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //var connection = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<FonourDbContext>
                (options => options.UseNpgsql(sqlConnectionString), ServiceLifetime.Scoped);

            services.AddScoped<UserRepository, UserRepository>();
            services.AddScoped<IUserAppService, UserAppService>();

            //services.AddDbContext<FonourDbContext>
            //    (options => options.UseNpgsql(sqlConnectionString), ServiceLifetime.Transient);
            //services.AddDbContext<FonourDbContext>
            //    (options => options.UseNpgsql(sqlConnectionString), ServiceLifetime.Scoped);
            //services.AddDbContext<FonourDbContext>
            //    (options => options.UseNpgsql(sqlConnectionString), ServiceLifetime.Singleton);
            //            注意：Asp.Net Core提供的依赖注入拥有三种生命周期模式，由短到长依次为：

            //    Transient ServiceProvider总是创建一个新的服务实例。
            //    Scoped ServiceProvider创建的服务实例由自己保存，
                    //（同一次请求）所以同一个ServiceProvider对象提供的服务实例均是同一个对象。
            //    Singleton 始终是同一个实例对象

            //对于数据访问上下文，我们可以通过重载方法的第二个参数，控制数据访问上下文对象的生命周期，默认生命周期为Scoped。

            //对于要依赖注入的接口和对象提供
            //    AddTransient、AddScoped、AddSingleton三个方法控制对象声明周期。

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
