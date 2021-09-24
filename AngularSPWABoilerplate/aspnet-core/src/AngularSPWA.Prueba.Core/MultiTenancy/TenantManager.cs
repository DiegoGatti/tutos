using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using AngularSPWA.Prueba.Authorization.Users;
using AngularSPWA.Prueba.Editions;

namespace AngularSPWA.Prueba.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
