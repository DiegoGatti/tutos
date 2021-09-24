using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AngularSPWA.Prueba.EntityFrameworkCore
{
    public static class PruebaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PruebaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PruebaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
