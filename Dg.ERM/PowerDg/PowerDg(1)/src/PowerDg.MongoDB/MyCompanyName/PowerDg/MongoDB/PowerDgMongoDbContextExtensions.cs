using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace PowerDg.MongoDB
{
    public static class PowerDgMongoDbContextExtensions
    {
        public static void ConfigurePowerDg(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new PowerDgMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}