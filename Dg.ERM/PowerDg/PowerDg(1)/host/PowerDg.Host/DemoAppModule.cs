using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PowerDg.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using Volo.Abp;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.Security.Claims;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.VirtualFileSystem;

//using Npgsql.EntityFrameworkCore.PostgreSQL;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PowerDg.Host
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PowerDgApplicationModule),
        typeof(PowerDgEntityFrameworkCoreModule),
        typeof(PowerDgHttpApiModule),
        typeof(AbpPermissionManagementEntityFrameworkCoreModule),
        typeof(AbpSettingManagementEntityFrameworkCoreModule),
        typeof(AbpAuditLoggingEntityFrameworkCoreModule),
        typeof(AbpEntityFrameworkCoreSqlServerModule)
        )]
    public class DemoAppModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.BuildConfiguration();

            Configure<DbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = configuration.GetConnectionString("Default");
            });

            Configure<AbpDbContextOptions>(options =>
            {
                //options.UseSqlServer();
                //options.UseNpgsql();
                options.Configure(context2 =>
                {
                    if (context2.ExistingConnection != null)
                    {
                        context2.DbContextOptions.UseNpgsql(context2.ExistingConnection);
                    }
                    else
                    {
                        context2.DbContextOptions.UseNpgsql(context2.ConnectionString);
                    }
                });
            });

            if (hostingEnvironment.IsDevelopment())
            {
                Configure<VirtualFileSystemOptions>(options =>
                {
                    options.FileSets.ReplaceEmbeddedByPhysical<PowerDgDomainModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}PowerDg.Domain", Path.DirectorySeparatorChar)));
                    options.FileSets.ReplaceEmbeddedByPhysical<PowerDgApplicationModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}PowerDg.Application", Path.DirectorySeparatorChar)));
                    options.FileSets.ReplaceEmbeddedByPhysical<PowerDgApplicationContractsModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}PowerDg.Application.Contracts", Path.DirectorySeparatorChar)));
                });
            }

            context.Services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new Info { Title = "PowerDg API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                    options.CustomSchemaIds(type => type.FullName);
                });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("en", "en", "English"));
                //...add other languages
            });

            context.Services.AddDistributedSqlServerCache(options =>
            {
                options.ConnectionString = configuration.GetConnectionString("SqlServerCache");
                options.SchemaName = "dbo";
                options.TableName = "TestCache";
            });

            context.Services.AddAuthentication("Bearer")
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = configuration["AuthServer:Authority"];
                    options.RequireHttpsMetadata = false;

                    options.ApiName = "api1";

                    //TODO: Can we make this by default?
                    options.InboundJwtClaimTypeMap["sub"] = AbpClaimTypes.UserId;
                    options.InboundJwtClaimTypeMap["role"] = AbpClaimTypes.Role;
                    options.InboundJwtClaimTypeMap["email"] = AbpClaimTypes.Email;
                });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            
            app.UseVirtualFiles();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Support APP API");
            });

            app.UseAuthentication();
            app.UseAbpRequestLocalization();
            app.UseAuditing();

            app.UseMvcWithDefaultRoute();
        }
    }
}
