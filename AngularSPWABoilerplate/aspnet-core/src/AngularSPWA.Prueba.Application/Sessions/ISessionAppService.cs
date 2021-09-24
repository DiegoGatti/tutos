using System.Threading.Tasks;
using Abp.Application.Services;
using AngularSPWA.Prueba.Sessions.Dto;

namespace AngularSPWA.Prueba.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
