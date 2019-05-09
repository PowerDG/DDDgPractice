using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DgMission.Scrapy
{
    public class TencentPosition:Entity<int>//, ICreationAudited
    { 
        //取消主键自增长，使用自我设计的主键
        //否则出现显示主键inseret 出错
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        //自增Id主键
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public new int? Id { get; set; }
        public string position_name { get; set; }
        public string position_link { get; set; }
        public string position_type { get; set; }
        public uint people_num { get; set; }
        public string work_address { get; set; }
        public DateTime publish_time { get; set; }


        //public long? CreatorUserId { get; set; }
        //public DateTime CreationTime { get; set; }
    }
}
