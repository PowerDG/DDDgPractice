using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DgCore.MyMission.EntityFrameworkCore
{
    public class MyMissionDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MyMissionDbContext(DbContextOptions<MyMissionDbContext> options) 
            : base(options)
        {

        }
    }
}
