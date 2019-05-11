using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dg.Core
{
    public class Users : AggregateRoot
    {
        public Users()
        {
            UsersRoles = new HashSet<UsersRoles>();
        }

        [StringLength(50)]
        public string Realname { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
    }

    public class UsersRoles : AggregateRoot
    {
        public UsersRoles()
        {
            Users = new HashSet<Users>();
        }

        [Display(Name = "角色名")]
        [Required(ErrorMessage = "请填写“{0}”")]
        [StringLength(50, ErrorMessage = "{0}最多{1}个字符")]
        public string Name { get; set; }

    }
    [Table("User2Role")]
    public class User2Role : AggregateRoot
    {
        public long UserId
        {
            get;
            set;
        }

        public long RoleId
        {
            get;
            set;
        }

    }
}
                                