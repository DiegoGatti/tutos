using Abp.Application.Services;
using AngularSPWA.Prueba.MultiTenancy.Dto;

namespace AngularSPWA.Prueba.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

