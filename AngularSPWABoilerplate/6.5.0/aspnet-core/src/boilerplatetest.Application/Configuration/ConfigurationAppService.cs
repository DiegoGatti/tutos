using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using boilerplatetest.Configuration.Dto;

namespace boilerplatetest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : boilerplatetestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
