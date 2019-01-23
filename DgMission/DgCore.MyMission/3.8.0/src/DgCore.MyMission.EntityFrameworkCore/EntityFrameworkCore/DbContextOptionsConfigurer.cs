using Microsoft.EntityFrameworkCore;

namespace DgCore.MyMission.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyMissionDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyMissionDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
