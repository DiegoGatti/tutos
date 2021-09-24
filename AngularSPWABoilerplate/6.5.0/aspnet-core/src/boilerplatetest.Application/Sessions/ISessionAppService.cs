using System.Threading.Tasks;
using Abp.Application.Services;
using boilerplatetest.Sessions.Dto;

namespace boilerplatetest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
