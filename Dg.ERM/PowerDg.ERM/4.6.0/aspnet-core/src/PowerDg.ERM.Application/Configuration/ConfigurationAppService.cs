using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PowerDg.ERM.Configuration.Dto;

namespace PowerDg.ERM.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ERMAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
