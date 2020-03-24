using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HoanAM.Configuration.Dto;

namespace HoanAM.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HoanAMAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
