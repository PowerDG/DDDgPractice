using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Trump.Domain
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> All();

        TEntity Single(long id);

        //TEntity Single(Expression<Func<TEntity, bool>> predicate);

        //TEntity Single(long id, params Expression<Func<TEntity, object>>[] propertySelectors);

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] propertySelectors);

        int Count();

        int Count(Expression<Func<TEntity, bool>> criteria);

        //IEnumerable<TEntity> Get<TOrderBy>(Expression<Func<TEntity, bool>> criteria
        //    , Expression<Func<TEntity, TOrderBy>> orderBy,
        //        int pageIndex, int pageSize);

        TEntity Delete(long id);

        bool Add(TEntity entity);

        bool Update(TEntity entity);

        int Save(TEntity entity);
    }
}
