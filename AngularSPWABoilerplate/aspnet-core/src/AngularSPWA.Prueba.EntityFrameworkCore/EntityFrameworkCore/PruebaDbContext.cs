using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AngularSPWA.Prueba.Authorization.Roles;
using AngularSPWA.Prueba.Authorization.Users;
using AngularSPWA.Prueba.MultiTenancy;

namespace AngularSPWA.Prueba.EntityFrameworkCore
{
    public class PruebaDbContext : AbpZeroDbContext<Tenant, Role, User, PruebaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PruebaDbContext(DbContextOptions<PruebaDbContext> options)
            : base(options)
        {
        }
    }
}
