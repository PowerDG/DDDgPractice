using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DgMission.EntityFrameworkCore
{
    public static class DgMissionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DgMissionDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);

        }

        public static void Configure(DbContextOptionsBuilder<DgMissionDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
