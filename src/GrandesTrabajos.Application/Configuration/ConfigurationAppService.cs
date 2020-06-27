using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GrandesTrabajos.Configuration.Dto;

namespace GrandesTrabajos.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GrandesTrabajosAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
