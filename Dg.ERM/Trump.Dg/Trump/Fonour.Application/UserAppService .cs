using Fonour.Domain.Users;
using Fonour.EntityFrameworkCore.Repositories;
using System;

namespace Fonour.Application
{

      public interface IUserAppService
    {

    }

    /// <summary>
    /// 用户管理服务
    /// </summary>
    public class UserAppService : IUserAppService
    {
        //用户管理仓储接口
        private readonly IUserRepository _userReporitory;

        /// <summary>
        /// 构造函数 实现依赖注入
        /// </summary>
        /// <param name="userRepository">仓储对象</param>
        public UserAppService(IUserRepository userRepository)
        {
            _userReporitory = userRepository;
        }

        public DgUser CheckUser(string userName, string password)
        {
            return _userReporitory.CheckUser(userName, password);
        }
    }
}
