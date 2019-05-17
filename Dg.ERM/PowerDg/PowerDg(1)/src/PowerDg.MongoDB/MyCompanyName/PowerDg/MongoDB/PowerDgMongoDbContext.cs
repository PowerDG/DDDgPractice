using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace PowerDg.MongoDB
{
    [ConnectionStringName("PowerDg")]
    public class PowerDgMongoDbContext : AbpMongoDbContext, IPowerDgMongoDbContext
    {
        public static string CollectionPrefix { get; set; } = PowerDgConsts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigurePowerDg(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}