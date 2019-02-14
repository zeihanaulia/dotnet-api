using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using dotnet-api.Configuration.Dto;

namespace dotnet-api.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : dotnet-apiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
