using Fonour.Domain.Users;
using Fonour.EntityFrameworkCore.FonourDbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fonour.EntityFrameworkCore.Repositories
{

    /// <summary>
    /// 用户管理仓储接口
    /// </summary>
    public interface IUserRepository : IRepository<DgUser>
    {
        /// <summary>
        /// 检查用户是存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>存在返回用户实体，否则返回NULL</returns>
        DgUser CheckUser(string userName, string password);
    }
    /// <summary>
    /// 用户管理仓储实现
    /// </summary>
    public class UserRepository : FonourRepositoryBase<DgUser>, IUserRepository
    {
        public UserRepository(FonourDbContext dbcontext) : base(dbcontext)
        {

        }
        /// <summary>
        /// 检查用户是存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>存在返回用户实体，否则返回NULL</returns>
        public DgUser CheckUser(string userName, string password)
        {
            return _dbContext.Set<DgUser>().FirstOrDefault(it => it.UserName == userName && it.Password == password);
        }
    }
}
