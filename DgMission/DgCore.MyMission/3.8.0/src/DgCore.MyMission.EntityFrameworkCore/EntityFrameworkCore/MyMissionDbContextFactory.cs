using DgCore.MyMission.Configuration;
using DgCore.MyMission.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DgCore.MyMission.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MyMissionDbContextFactory : IDesignTimeDbContextFactory<MyMissionDbContext>
    {
        public MyMissionDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyMissionDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MyMissionConsts.ConnectionStringName)
            );

            return new MyMissionDbContext(builder.Options);
        }
    }
}