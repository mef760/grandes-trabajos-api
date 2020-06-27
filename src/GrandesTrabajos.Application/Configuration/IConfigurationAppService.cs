using System.Threading.Tasks;
using GrandesTrabajos.Configuration.Dto;

namespace GrandesTrabajos.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
