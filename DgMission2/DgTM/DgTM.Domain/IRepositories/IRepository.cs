using System;
using System.Collections.Generic;
using System.Text;

namespace DgTM.Domain.IRepositories
{
    /// <summary>
    /// 仓储接口，定义公共的泛型GRUD
    /// </summary>
    /// <typeparam name="TEntity">泛型聚合根，因为在DDD里面仓储只能对聚合根做操作</typeparam>
    public interface IRepository<TEntity> where TEntity : AggregateRoot
    {
        #region 属性
        IQueryable<TEntity> Entities { get; }
        #endregion

        #region 公共方法
        int Insert(TEntity entity);

        int Insert(IEnumerable<TEntity> entities);

        int Delete(object id);

        int Delete(TEntity entity);

        int Delete(IEnumerable<TEntity> entities);

        int Update(TEntity entity);

        TEntity GetByKey(object key);
        #endregion
    }
}
