using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DgMission.Roles.Dto;
using DgMission.Users.Dto;

namespace DgMission.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
