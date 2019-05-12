using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Trump.Domain;

namespace Trump.Host.Core
{
    /// <summary>
    /// 用MVC5+EF6+WebApi 做一个考试功能(六) 仓储模式 打造EF通用仓储类
    /// https://www.cnblogs.com/buyixiaohan/p/8384874.html
    /// 
    ///  错误 CS1061  “MyDbContext”未包含“Configuration”的定义，
    ///  并且找不到可接受第一个“MyDbContext”类型参数的可访问扩展方法“Configuration”(是否缺少 using 指令或程序集引用?)	Trump.EF E:\DgProject\DDDgPractice\Dg.ERM\Trump.Dg\Trump\Trump.EF\GenericRepository.cs	20	活动的

    /// 
    /// 
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class GenericRepository<TEntity> : IRepository<TEntity> 
        where TEntity : EneityOfLongPrimarykey
    {
        public MyDbContext context;

        public GenericRepository()
        {
              context = new MyDbContext();
            // Load navigation properties explicitly (avoid serialization trouble)
            context.Configuration.LazyLoadingEnabled = false;

            // Do NOT enable proxied entities, else serialization fails.
            context.Configuration.ProxyCreationEnabled = false;

            // Because Web API will perform validation, we don't need/want EF to do so
            context.Configuration.ValidateOnSaveEnabled = false;
        }

        public virtual IQueryable<TEntity> All()
        {
            return context.Set<TEntity>().AsQueryable();
        }

        public TEntity Single(long id)
        {
            return All().Single(t => t.Id == id);
        }

        //public TEntity Single(long id, params Expression<Func<TEntity, object>>[] propertySelectors)
        //{
        //    return Find(s => s.Id == id, propertySelectors).FirstOrDefault();
        //}

        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            return All().Single(predicate);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate != null)
            {
                return All().Where(predicate).AsNoTracking();
            }
            else
            {
                return All();
            }
        }

        /// <summary>
        /// 取过滤数据，启用延迟查询
        /// </summary>
        /// <param name="predicate">过滤条件</param>
        /// <param name="propertySelectors">需要Left Join 的表</param>
        /// <returns></returns>
        //public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] propertySelectors)
        //{
        //    if (propertySelectors.IsNullOrEmpty())
        //    {
        //        return Find(predicate);
        //    }

        //    var query = Find(predicate);

        //    foreach (var propertySelector in propertySelectors)
        //    {
        //        query = query.Include(propertySelector);
        //    }

        //    return query;
        //}

        public int Count()
        {
            return All().Count();
        }

        public int Count(Expression<Func<TEntity, bool>> criteria)
        {
            return All().Count(criteria);
        }

        //public IEnumerable<TEntity> Get<TOrderBy>(Expression<Func<TEntity, bool>> criteria, Expression<Func<TEntity, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        //{
        //    if (sortOrder == SortOrder.Ascending)
        //    {
        //        return All().OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsEnumerable();
        //    }
        //    return All().OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsEnumerable();
        //}

        public TEntity Delete(long id)
        {
            var entity = Single(id);
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
            return entity;
        }

        public bool Add(TEntity entity)
        {
            if (context.Entry<TEntity>(entity).State != EntityState.Detached)
            {
                context.Entry<TEntity>(entity).State = EntityState.Added;
            }
            context.Set<TEntity>().Add(entity);
            return context.SaveChanges() > 0;
        }

        public bool Update(TEntity entity)
        {
            if (context.Entry<TEntity>(entity).State != EntityState.Detached)
            {
                context.Set<TEntity>().Attach(entity);
            }
            context.Entry<TEntity>(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }

        public int Save(TEntity entity)
        {
            return context.SaveChanges();
        }

    }

    public class MyDbContext : DbContext
    {
        //public object Configuration { get; internal set; }
        public object Configuration { get; internal set; }
    }

    public class EneityOfLongPrimarykey
    {
        public long Id { get; internal set; }
    }
}
