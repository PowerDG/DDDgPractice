using System;
using System.Collections.Generic;
using System.Text;

namespace DgTM.Domain.IRepositories
{
    /// <summary>
    /// 部门聚合根的仓储接口
    /// </summary>
    public interface IDepartmentRepository : IRepository<TB_DEPARTMENT>
    {

    }


    /// <summary>
    /// 角色这个聚合根的仓储接口
    /// </summary>
    public interface IRoleRepository : IRepository<TB_ROLE>
    {
    }
}
