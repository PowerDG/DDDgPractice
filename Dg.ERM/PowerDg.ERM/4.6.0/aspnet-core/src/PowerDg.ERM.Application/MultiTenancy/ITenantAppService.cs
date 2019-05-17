using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PowerDg.ERM.MultiTenancy.Dto;

namespace PowerDg.ERM.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

