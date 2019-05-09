using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DgMission.Authorization.Roles;
using DgMission.Authorization.Users;
using DgMission.MultiTenancy;

namespace DgMission.EntityFrameworkCore
{
    public class DgMissionDbContext : AbpZeroDbContext<Tenant, Role, User, DgMissionDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DgMissionDbContext(DbContextOptions<DgMissionDbContext> options)
            : base(options)
        {
        }
    }
}
