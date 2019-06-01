using System;
using System.Collections.Generic;
using System.Text;

namespace DgTM.Domain
{
    //用作泛型约束，表示继承自该接口的为领域实体
    public interface IEntity
    {

    }


    /// <summary>
    /// 聚合根接口，用作泛型约束，约束领域实体为聚合根，表示实现了该接口的为聚合根实例，由于聚合根也是领域实体的一种，所以也要实现IEntity接口
    /// </summary>
    public interface IAggregateRoot : IEntity
    {

    }

    /// <summary>
    /// 聚合根的抽象实现类，定义聚合根的公共属性和行为
    /// </summary>
    public abstract class AggregateRoot : IAggregateRoot
    {

    }
}
