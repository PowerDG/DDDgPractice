using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DgMission.Authorization.Roles;
using DgMission.Authorization.Users;
using DgMission.MultiTenancy;
using DgMission.Scrapy;

namespace DgMission.EntityFrameworkCore
{
    public class DgMissionDbContext : AbpZeroDbContext<Tenant, Role, User, DgMissionDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<TencentPosition> TencentPositions { get; set; }
        public DgMissionDbContext(DbContextOptions<DgMissionDbContext> options)
            : base(options)
        {
        }
    }
}
