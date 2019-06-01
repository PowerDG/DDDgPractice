using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Trump.Domain
{
    /// <summary>
    /// 
    /// 
    /// 用MVC5+EF6+WebApi 做一个小功能(三) 项目搭建
    /// https://www.cnblogs.com/buyixiaohan/p/8279858.html
    /// 用MVC5+EF6+WebApi 做一个小功能(四) 项目分层功能以及文件夹命名
    /// https://www.cnblogs.com/buyixiaohan/p/8299244.html
    /// 
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
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
