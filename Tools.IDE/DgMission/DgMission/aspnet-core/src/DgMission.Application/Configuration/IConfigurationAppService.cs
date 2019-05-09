using System.Threading.Tasks;
using DgMission.Configuration.Dto;

namespace DgMission.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
