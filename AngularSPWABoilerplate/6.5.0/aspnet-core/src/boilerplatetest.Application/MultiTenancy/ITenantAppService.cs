using Abp.Application.Services;
using boilerplatetest.MultiTenancy.Dto;

namespace boilerplatetest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

