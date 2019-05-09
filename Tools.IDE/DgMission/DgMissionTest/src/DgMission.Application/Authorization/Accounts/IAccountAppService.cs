using System.Threading.Tasks;
using Abp.Application.Services;
using DgMission.Authorization.Accounts.Dto;

namespace DgMission.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
