using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LibraryManagementSystem.Configuration.Dto;

namespace LibraryManagementSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LibraryManagementSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
