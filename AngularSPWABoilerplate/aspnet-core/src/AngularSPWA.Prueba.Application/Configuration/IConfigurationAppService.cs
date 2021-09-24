using System.Threading.Tasks;
using AngularSPWA.Prueba.Configuration.Dto;

namespace AngularSPWA.Prueba.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
