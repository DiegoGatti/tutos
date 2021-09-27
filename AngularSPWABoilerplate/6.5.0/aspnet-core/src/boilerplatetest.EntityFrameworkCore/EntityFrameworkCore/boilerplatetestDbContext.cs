using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using boilerplatetest.Authorization.Roles;
using boilerplatetest.Authorization.Users;
using boilerplatetest.MultiTenancy;
using boilerplatetest.Core.Entities;

namespace boilerplatetest.EntityFrameworkCore
{
    public class boilerplatetestDbContext : AbpZeroDbContext<Tenant, Role, User, boilerplatetestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Client> Clients { get; set; }
        
        public boilerplatetestDbContext(DbContextOptions<boilerplatetestDbContext> options)
            : base(options)
        {
        }
    }
}
