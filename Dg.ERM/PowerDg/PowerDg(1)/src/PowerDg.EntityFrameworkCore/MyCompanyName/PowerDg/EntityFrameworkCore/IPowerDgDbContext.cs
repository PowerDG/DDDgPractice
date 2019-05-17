using Microsoft.EntityFrameworkCore;
using MyCompanyName;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace PowerDg.EntityFrameworkCore
{
    [ConnectionStringName("PowerDg")]
    public interface IPowerDgDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */

        DbSet<Question> Questions { get; }
    }
}