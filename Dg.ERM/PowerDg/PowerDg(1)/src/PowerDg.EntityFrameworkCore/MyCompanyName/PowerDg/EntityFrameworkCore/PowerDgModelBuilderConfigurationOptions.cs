using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace PowerDg.EntityFrameworkCore
{
    public class PowerDgModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public PowerDgModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = PowerDgConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = PowerDgConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}