using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using boilerplatetest.Authorization.Roles;
using boilerplatetest.Authorization.Users;
using boilerplatetest.MultiTenancy;

namespace boilerplatetest.EntityFrameworkCore
{
    public class boilerplatetestDbContext : AbpZeroDbContext<Tenant, Role, User, boilerplatetestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public boilerplatetestDbContext(DbContextOptions<boilerplatetestDbContext> options)
            : base(options)
        {
        }
    }
}
