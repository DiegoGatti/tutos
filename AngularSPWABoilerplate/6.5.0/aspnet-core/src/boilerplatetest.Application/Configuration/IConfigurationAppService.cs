using System.Threading.Tasks;
using boilerplatetest.Configuration.Dto;

namespace boilerplatetest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
