﻿/* ===============================================================
 * 创 建 者：wms
 * 创建日期：2016/11/18 17:13:56
 * 功能描述：仓储实现类
 * ===============================================================*/
  
using Microsoft.EntityFrameworkCore;
 
using global::Framework.EF.Framework.EF;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Linq.Expressions;

/// <summary>
/// 
/// ASP.NET Mvc实用框架（一）Ioc、仓储模式和单元工作模式
/// 
/// https://www.yuanmas.com/info/9warVrnaAE.html
/// 
/// 仓储实现类
/// </summary>
public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// 上下文
    /// </summary>
    protected DbContext dbContext;

    /// <summary>
    /// DbSet
    /// </summary>
    protected DbSet<TEntity> dbSet;

    /// <summary>
    /// 无参构造函数《用于单独的Service直接使用》
    /// </summary>
    public Repository() { }

    /// <summary>
    /// 用于UnitOfWork
    /// </summary>
    /// <param name="dbContext">上下文</param>
    public Repository(DbContext dbContext)
    {
        this.dbContext = dbContext;
        this.dbSet = dbContext.Set<TEntity>();
    }

    #region 删除操作

    /// <summary>
    /// 删除操作
    /// </summary>
    /// <param name="entityToDelete"></param>
    public virtual void Delete(TEntity entityToDelete)
    {
        if (dbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }
        dbSet.Remove(entityToDelete);
    }

    /// <summary>
    /// 删除/批量删除
    /// </summary>
    /// <param name="predicate">表达式</param>
    /// <returns></returns>
    //public virtual int Delete(Expression<Func<TEntity, bool>> predicate)
    //{
    //    return this.dbSet.Delete(predicate);
    //}

    #endregion

    #region 更新操作

    /// <summary>
    /// 批量更新
    /// <code><![CDATA[
    /// var db = new TrackerContext();
    /// string emailDomain = "@test.com";
    /// int count = db.Users.Update(
    ///   u => u.Email.EndsWith(emailDomain),
    ///   u => new User { IsApproved = false, LastActivityDate = DateTime.Now });
    /// ]]></code>
    /// </summary>
    /// <param name="filterExpression">条件筛选表达式</param>
    /// <param name="updateExpression">更新表达式</param>
    //public virtual int Update(Expression<Func<TEntity, bool>> filterExpression,
    //    Expression<Func<TEntity, TEntity>> updateExpression)
    //{
    //    return this.dbSet.Update()
    //        //.Update(filterExpression, updateExpression);
    //}

    #endregion

    #region 新增操作

    /// <summary>
    /// 新增
    /// </summary>
    /// <param name="entity">要新增的实体</param>
    //public virtual TEntity Insert(TEntity entity)
    //{
    //    return dbSet.Add(entity);
    //}
    #endregion

    #region 查询操作

    #region Count

    /// <summary>
    /// Count查询
    /// </summary>
    /// <returns></returns>
    public virtual int Count()
    {
        return this.dbSet.Count();
    }

    /// <summary>
    /// Count查询
    /// </summary>
    /// <param name="predicate">条件表达式</param>
    /// <returns></returns>
    public virtual int Count(Expression<Func<TEntity, bool>> predicate)
    {
        return this.dbSet.Count();
    }

    #endregion

    #region 单个查询

    /// <summary>
    /// 取查询结果中的第一条（为空抛异常）
    /// </summary>
    /// <returns></returns>
    public virtual TEntity First()
    {
        return this.dbSet.First();
    }

    /// <summary>
    /// 取查询结果中的第一条（为空抛异常）
    /// </summary>
    /// <param name="predicate">条件表达式</param>
    /// <returns></returns>
    public virtual TEntity First(Expression<Func<TEntity, bool>> predicate)
    {
        return this.dbSet.First(predicate);
    }
    /// <summary>
    /// 取查询结果中的第一条（为空返回默认值）
    /// </summary>
    /// <returns></returns>
    public virtual TEntity FirstOrDefault()
    {
        return this.dbSet.FirstOrDefault();
    }
    /// <summary>
    /// 取查询结果中的第一条（为空返回默认值）
    /// </summary>
    /// <param name="predicate">条件表达式</param>
    /// <returns></returns>
    public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
    {
        return this.dbSet.FirstOrDefault(predicate);
    }

    /// <summary>
    /// 取一条数据（为空抛异常）
    /// </summary>
    /// <returns></returns>
    public virtual TEntity Single()
    {
        return this.dbSet.Single();
    }

    /// <summary>
    /// 取一条数据（为空抛异常）
    /// </summary>
    /// <param name="predicate">条件表达式</param>
    /// <returns></returns>
    public virtual TEntity Single(Expression<Func<TEntity, bool>> predicate)
    {
        return this.dbSet.Single(predicate);
    }

    /// <summary>
    /// 取一条数据（没有为空）
    /// </summary>
    /// <returns></returns>
    public virtual TEntity SingleOrDefault()
    {
        return this.dbSet.SingleOrDefault();
    }

    /// <summary>
    /// 取一条数据（没有为空）
    /// </summary>
    /// <param name="predicate">条件表达式</param>
    /// <returns></returns>
    public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
    {
        return this.dbSet.SingleOrDefault(predicate);
    }

    #endregion

    /// <summary>
    /// 获取列表(延迟加载)
    /// </summary>
    /// <param name="predicate">表达式树</param>
    /// <returns></returns>
    public virtual IQueryable<TEntity> LoadEntities(Expression<Func<TEntity, bool>> predicate)
    {
        return this.dbSet.Where(predicate);
    }

    #region 分页查询

    /// <summary>
    /// 分页查询
    /// </summary>
    /// <typeparam name="TKey">排序类型</typeparam>
    /// <param name="pageIndex">当前页</param>
    /// <param name="pageSize">每页大小</param>
    /// <param name="isAsc">是否升序排列</param>
    /// <param name="keySelector">排序表达式</param>
    /// <returns></returns>
    //public virtual IPage<TEntity> Page<TKey>(int pageIndex, int pageSize, bool isAsc, Expression<Func<TEntity, TKey>> keySelector)
    //{
    //    return this.Page(pageIndex, pageSize, null, isAsc, keySelector);
    //}

    /// <summary>
    /// 分页查询
    /// </summary>
    /// <typeparam name="TKey">排序类型</typeparam>
    /// <param name="pageIndex">当前页</param>
    /// <param name="pageSize">每页大小</param>
    /// <param name="isAsc">是否升序排列</param>
    /// <param name="predicate">条件表达式</param>
    /// <param name="keySelector">排序表达式</param>
    /// <returns></returns>
    //public virtual IPage<TEntity> Page<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, bool>> predicate, bool isAsc,
    //    Expression<Func<TEntity, TKey>> keySelector)
    //{
    //    if (pageIndex <= 0 && pageSize <= 0)
    //    {
    //        throw new Exception("pageIndex或pageSize不能小于等于0！");
    //    }
    //    IPage<TEntity> page = new Page<TEntity>()
    //    {
    //        PageIndex = pageIndex,
    //        PageSize = pageSize
    //    };
    //    int skip = (pageIndex - 1) * pageSize;
    //    if (predicate == null)
    //    {
    //        FutureCount fcount = this.dbSet.FutureCount();
    //        FutureQuery<TEntity> futureQuery = isAsc
    //            ? this.dbSet.OrderBy(keySelector).Skip(skip).Take(pageSize).Future()
    //            : this.dbSet.OrderByDescending(keySelector).Skip(skip).Take(pageSize).Future();
    //        page.TotalItems = fcount.Value;
    //        page.Items = futureQuery.ToList();
    //        page.TotalPages = page.TotalItems / pageSize;
    //        if ((page.TotalItems % pageSize) != 0) page.TotalPages++;
    //    }
    //    else
    //    {
    //        var queryable = this.dbSet.Where(predicate);
    //        FutureCount fcount = queryable.FutureCount();
    //        FutureQuery<TEntity> futureQuery = isAsc
    //            ? queryable.OrderBy(keySelector).Skip(skip).Take(pageSize).Future()
    //            : queryable.OrderByDescending(keySelector).Skip(skip).Take(pageSize).Future();
    //        page.TotalItems = fcount.Value;
    //        page.Items = futureQuery.ToList();
    //        page.TotalPages = page.TotalItems / pageSize;
    //        if ((page.TotalItems % pageSize) != 0) page.TotalPages++;
    //    }
    //    return page;
    //}

    #endregion

    #endregion

    /// <summary>
    /// 资源释放
    /// </summary>
    public virtual void Dispose()
    {
        dbContext.Dispose();
    }

    /// <summary>
    /// 保存修改
    /// </summary>
    /// <returns></returns>
    public virtual int SaveChanges()
    {
        return this.dbContext.SaveChanges();
    }
 
}
