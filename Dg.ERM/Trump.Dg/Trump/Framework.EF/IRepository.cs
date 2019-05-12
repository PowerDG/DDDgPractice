using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.EF
{
    /* ===============================================================
     * 创 建 者：wms
     * 创建日期：2016/11/18 17:06:34
     * 功能描述：仓储接口
     * ===============================================================*/

    namespace Framework.EF
    {
        using System;
        using System.Linq;
        using System.Linq.Expressions;

        /// <summary>
        /// 仓储接口
        /// </summary>
        public interface IRepository<TEntity> : IDisposable where TEntity : class
        {

            #region 删除操作

            /// <summary>
            /// 删除实体
            /// </summary>
            /// <param name="entityToDelete">要删除的实体</param>
            void Delete(TEntity entityToDelete);

            /// <summary>
            /// 删除/批量删除
            /// </summary>
            /// <param name="predicate">表达式</param>
            /// <returns></returns>
            //int Delete(Expression<Func<TEntity, bool>> predicate);

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
            //int Update(Expression<Func<TEntity, bool>> filterExpression,
            //    Expression<Func<TEntity, TEntity>> updateExpression);
            #endregion

            #region 新增操作

            /// <summary>
            /// 新增
            /// </summary>
            /// <param name="entity">要新增的实体</param>
            //TEntity Insert(TEntity entity);
            #endregion

            #region 查询操作

            #region Count
            /// <summary>
            /// Count查询
            /// </summary>
            /// <returns></returns>
            int Count();
            /// <summary>
            /// Count查询
            /// </summary>
            /// <param name="predicate">条件表达式</param>
            /// <returns></returns>
            int Count(Expression<Func<TEntity, bool>> predicate);

            #endregion

            #region 单个查询

            /// <summary>
            /// 取查询结果中的第一条（为空抛异常）
            /// </summary>
            /// <returns></returns>
            TEntity First();

            /// <summary>
            /// 取查询结果中的第一条（为空抛异常）
            /// </summary>
            /// <param name="predicate">条件表达式</param>
            /// <returns></returns>
            TEntity First(Expression<Func<TEntity, bool>> predicate);
            /// <summary>
            /// 取查询结果中的第一条（为空返回默认值）
            /// </summary>
            /// <returns></returns>
            TEntity FirstOrDefault();
            /// <summary>
            /// 取查询结果中的第一条（为空返回默认值）
            /// </summary>
            /// <param name="predicate">条件表达式</param>
            /// <returns></returns>
            TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

            /// <summary>
            /// 取一条数据（为空抛异常）
            /// </summary>
            /// <returns></returns>
            TEntity Single();

            /// <summary>
            /// 取一条数据（为空抛异常）
            /// </summary>
            /// <param name="predicate">条件表达式</param>
            /// <returns></returns>
            TEntity Single(Expression<Func<TEntity, bool>> predicate);

            /// <summary>
            /// 取一条数据（没有为空）
            /// </summary>
            /// <returns></returns>
            TEntity SingleOrDefault();

            /// <summary>
            /// 取一条数据（没有为空）
            /// </summary>
            /// <param name="predicate">条件表达式</param>
            /// <returns></returns>
            TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

            #endregion

            /// <summary>
            /// 获取列表(延迟加载)
            /// </summary>
            /// <param name="predicate">表达式树</param>
            /// <returns></returns>
            IQueryable<TEntity> LoadEntities(Expression<Func<TEntity, bool>> predicate);

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
            //IPage<TEntity> Page<TKey>(int pageIndex, int pageSize, bool isAsc, Expression<Func<TEntity, TKey>> keySelector);

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
            //IPage<TEntity> Page<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, bool>> predicate, bool isAsc,
                //Expression<Func<TEntity, TKey>> keySelector);

            #endregion

            #endregion

            /// <summary>
            /// 保存修改
            /// </summary>
            /// <returns></returns>
            int SaveChanges();
        }
    }


}
