using Microsoft.EntityFrameworkCore;
using MyCompanyName;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace PowerDg.EntityFrameworkCore
{
    [ConnectionStringName("PowerDg")]
    public class PowerDgDbContext : AbpDbContext<PowerDgDbContext>, IPowerDgDbContext
    {
        public static string TablePrefix { get; set; } = PowerDgConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = PowerDgConsts.DefaultDbSchema;

        public DbSet<Question> Questions { get; set; }

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public PowerDgDbContext(DbContextOptions<PowerDgDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigurePowerDg(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}