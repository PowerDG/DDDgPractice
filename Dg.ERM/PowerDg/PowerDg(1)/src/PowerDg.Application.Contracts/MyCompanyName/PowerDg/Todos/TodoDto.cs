using System;
using Volo.Abp.Application.Dtos;

namespace PowerDg.Todos
{
    public class TodoDto : EntityDto<Guid>
    {
        public string Text { get; set; }
    }
}