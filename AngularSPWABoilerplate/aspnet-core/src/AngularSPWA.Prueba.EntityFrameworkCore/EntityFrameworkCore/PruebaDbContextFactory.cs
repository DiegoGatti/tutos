using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AngularSPWA.Prueba.Configuration;
using AngularSPWA.Prueba.Web;

namespace AngularSPWA.Prueba.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PruebaDbContextFactory : IDesignTimeDbContextFactory<PruebaDbContext>
    {
        public PruebaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PruebaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PruebaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PruebaConsts.ConnectionStringName));

            return new PruebaDbContext(builder.Options);
        }
    }
}
