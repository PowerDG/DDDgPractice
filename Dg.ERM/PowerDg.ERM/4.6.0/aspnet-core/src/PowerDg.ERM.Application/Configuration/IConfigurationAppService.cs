using System.Threading.Tasks;
using PowerDg.ERM.Configuration.Dto;

namespace PowerDg.ERM.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
