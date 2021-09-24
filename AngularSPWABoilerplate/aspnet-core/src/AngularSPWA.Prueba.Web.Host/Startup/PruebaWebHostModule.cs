using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AngularSPWA.Prueba.Configuration;

namespace AngularSPWA.Prueba.Web.Host.Startup
{
    [DependsOn(
       typeof(PruebaWebCoreModule))]
    public class PruebaWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PruebaWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PruebaWebHostModule).GetAssembly());
        }
    }
}
