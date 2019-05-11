using System;

namespace Dg.Core
{
    public interface IAggregateRoot
    {
        long Id { get; set; }

        long CreateUserId { get; set; }
        string CreateUserName { get; set; }

        DateTime UpdateTime { get; set; }
    }
    /// <summary>
    /// Asp.Net DDD架构浅谈——整体框架说明
    /// https://www.jianshu.com/p/c9b28468015e
    /// 
    /// Asp.Net DDD架构浅谈——领域划分、仓储应用、Services层定义
    /// https://www.jianshu.com/p/c0a8b6447d29
    /// 
    /// Asp.Net DDD架构浅谈——依赖注入Autofac
    /// https://www.jianshu.com/p/f5d6346b0a7b
    /// 
    /// Asp.Net DDD架构浅谈——网站配置
    /// https://www.jianshu.com/p/37c906f88f8a
    /// </summary>
    public class AggregateRoot
    {

    }
}