using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DgMission.Configuration;
using DgMission.Web;

namespace DgMission.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DgMissionDbContextFactory : IDesignTimeDbContextFactory<DgMissionDbContext>
    {
        public DgMissionDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DgMissionDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DgMissionDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DgMissionConsts.ConnectionStringName));

            return new DgMissionDbContext(builder.Options);
        }
    }
}
