using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace PowerDg.MongoDB
{
    [ConnectionStringName("PowerDg")]
    public interface IPowerDgMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
