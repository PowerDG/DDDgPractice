using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace PowerDg.MongoDB
{
    public class PowerDgMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public PowerDgMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = PowerDgConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}