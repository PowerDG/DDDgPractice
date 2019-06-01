using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDg.EntityFrameworkCore
{
    public interface IDbContext
    {

        /// <summary>
        /// 获得实体集合
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        DbSet<TEntity> Set<TEntity>() where TEntity : class;


        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="commandText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters)
        where TEntity : class;


        /// <summary>
        /// 执行SQL语句查询
        /// </summary>
        /// <typeparam name="TElement"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters);


        EntityEntry Entry<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        int SaveChanges();



        /// <summary>
        /// 变更追踪代码
        /// </summary>
        bool ProxyCreationEnabled { get; set; }


        /// <summary>
        /// DetectChanges方法自动调用
        /// </summary>
        bool AutoDetectChangesEnabled { get; set; }

        /// <summary>
        /// 调用Dispose方法
        /// </summary>
        void Dispose();

    }
}
