using Fonour.Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fonour.EntityFrameworkCore.FonourDbContexts
{

    /// <summary>
    /// /
    /// Asp.Net Core 项目实战之权限管理系统（3） 通过EntityFramework Core使用PostgreSQL
    /// http://www.cnblogs.com/fonour/p/5886292.html
    /// Asp.Net Core 项目实战之权限管理系统（4） 依赖注入、仓储、服务的多项目分层实现
    /// http://www.cnblogs.com/fonour/p/5904530.html
    /// 
    /// Entity Framework (EF) Core 是轻量化、可扩展、开源和跨平台版的常用 Entity Framework 数据访问技术。
    /// https://docs.microsoft.com/zh-cn/ef/core/index
    /// </summary>
    public class FonourDbContext : DbContext
    {
        public FonourDbContext(DbContextOptions<FonourDbContext> options) : base(options)
        {

        }
        public DbSet<DgUser> Users { get; set; }
        //public DbSet<Department> Departments { get; set; }
        public DbSet<Menu> Menus { get; set; }
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }
        //public DbSet<RoleMenu> RoleMenus { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //UserRole关联配置
            //builder.Entity<UserRole>()
            //  .HasKey(ur => new { ur.UserId, ur.RoleId });

            ////RoleMenu关联配置
            //builder.Entity<RoleMenu>()
            //  .HasKey(rm => new { rm.RoleId, rm.MenuId });
            //builder.Entity<RoleMenu>()
            //  .HasOne(rm => rm.Role)
            //  .WithMany(r => r.RoleMenus)
            //  .HasForeignKey(rm => rm.RoleId).HasForeignKey(rm => rm.MenuId);

            ////启用Guid主键类型扩展
            //builder.HasPostgresExtension("uuid-ossp");

            base.OnModelCreating(builder);
        }
    }
}
