using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DgMission.Configuration.Dto;

namespace DgMission.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DgMissionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
