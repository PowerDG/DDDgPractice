using System;
using System.Collections.Generic;
using System.Text;
namespace Fonour.Domain.SysUserRoles
{
    public class SysUser
    {
        public long ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        public string Description { get; set; }

    }


    public class SysRole
    {
        public long ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        public string Description { get; set; }

    }


    public class SysUserRole
    {
        public long ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
