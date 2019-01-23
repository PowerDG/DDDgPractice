using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DgMission.MultiTenancy.Dto;

namespace DgMission.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

