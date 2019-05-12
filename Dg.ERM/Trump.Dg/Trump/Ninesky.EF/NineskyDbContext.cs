using Microsoft.EntityFrameworkCore;
using Ninesky.Models;
//using System.Data.Entity;

namespace Ninesky.DAL
{
    /// <summary>
    /// 数据上下文
    /// ASP.NET MVC5 网站开发实践(一) - 框架（续） 模型、数据存储、业务逻辑
    /// 
    /// http://www.cnblogs.com/mzwhj/p/3547394.html
    /// 
    /// 
    /// 、https://blog.csdn.net/hanjun0612/article/details/52860901
    /// 
    /// Ninesky, 是洞庭夕照基于.NET Core 2.0开发的一个开源网站demo。 
    /// 如要打开源码请先安装.NET Core 2.0 
    /// <remarks>创建：2014.02.03</remarks>
    /// </summary>
    public class NineskyDbContext : DbContext
    {



        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }
        public NineskyDbContext()
            : base("DefaultConnection")
        {
        }
    }
}