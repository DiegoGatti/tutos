using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace boilerplatetest.EntityFrameworkCore
{
    public static class boilerplatetestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<boilerplatetestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<boilerplatetestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
