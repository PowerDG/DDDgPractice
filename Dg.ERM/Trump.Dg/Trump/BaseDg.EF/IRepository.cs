using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDg.EF
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region 属性
        //IQueryable Entities { get; }
        #endregion

        #region 公共方法
        void Insert(TEntity entity);

        void Insert(IEnumerable<TEntity> entities);

        void Delete(object id);

        void Delete(TEntity entity);

        void Delete(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        TEntity GetByKey(object key);
        #endregion
    }
}
