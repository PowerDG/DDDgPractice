using System.Threading.Tasks;
using Abp.Application.Services;
using PowerDg.ERM.Sessions.Dto;

namespace PowerDg.ERM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
