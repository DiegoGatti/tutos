using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AngularSPWA.Prueba.Configuration.Dto;

namespace AngularSPWA.Prueba.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PruebaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
