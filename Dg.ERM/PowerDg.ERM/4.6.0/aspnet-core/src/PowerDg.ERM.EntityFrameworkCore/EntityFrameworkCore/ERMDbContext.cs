using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PowerDg.ERM.Authorization.Roles;
using PowerDg.ERM.Authorization.Users;
using PowerDg.ERM.MultiTenancy;

namespace PowerDg.ERM.EntityFrameworkCore
{
    public class ERMDbContext : AbpZeroDbContext<Tenant, Role, User, ERMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ERMDbContext(DbContextOptions<ERMDbContext> options)
            : base(options)
        {
        }
    }
}
