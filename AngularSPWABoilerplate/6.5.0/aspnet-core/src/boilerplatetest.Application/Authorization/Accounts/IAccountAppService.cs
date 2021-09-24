using System.Threading.Tasks;
using Abp.Application.Services;
using boilerplatetest.Authorization.Accounts.Dto;

namespace boilerplatetest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
