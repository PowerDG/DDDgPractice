using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TestEF.EF
{
    /// <summary>
    /// 
    /// 
    /// 
    /// https://www.cnblogs.com/JoeSnail/p/8310407.html
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    //泛型仓储基类
    public class EFBaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //数据上下文
        internal DbContext context;
        //数据集
        internal DbSet<TEntity> dbSet;

        public EFBaseRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        //public IQueryable Entities => context.Set<TEntity>();

        public void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public TEntity GetByKey(object key)
        {
            return dbSet.Find(key);
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
            dbSet.AddRange(entities);
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "", int topNum = 0)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (topNum != 0)
            {
                return query.Take(topNum);
            }
            else
            {
                return query.ToList();
            }
        }
    }
}
