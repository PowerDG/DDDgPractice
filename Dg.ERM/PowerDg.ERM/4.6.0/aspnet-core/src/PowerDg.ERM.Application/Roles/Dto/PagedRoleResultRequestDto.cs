using Abp.Application.Services.Dto;

namespace PowerDg.ERM.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

