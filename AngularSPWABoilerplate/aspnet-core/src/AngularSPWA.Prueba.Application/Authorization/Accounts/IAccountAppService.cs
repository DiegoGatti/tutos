using System.Threading.Tasks;
using Abp.Application.Services;
using AngularSPWA.Prueba.Authorization.Accounts.Dto;

namespace AngularSPWA.Prueba.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
