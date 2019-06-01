using System;
using System.Collections.Generic;
using System.Text;

namespace DgTM.Domain.Model
{
    public partial class TB_DEPARTMENT : AggregateRoot
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }



    public partial class Department : IEntity
    {

    }

    public partial class TB_MENU : AggregateRoot
    {

    }

    /// <summary>
    /// 由于不会直接操作此表，所以TB_MENUROLE实体不必作为聚合根，只是作为领域实体即可
    /// </summary>
    public partial class TB_MENUROLE : IEntity
    {
    }



    public partial class TB_ROLE : AggregateRoot
    {
    }

    public partial class TB_USERROLE : IEntity
    {
    }

    public partial class TB_USERS : AggregateRoot
    {
    }


}
