using Abp.MultiTenancy;
using AngularSPWA.Prueba.Authorization.Users;

namespace AngularSPWA.Prueba.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
