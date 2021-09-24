using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplatetest.Configuration;

namespace boilerplatetest.Web.Host.Startup
{
    [DependsOn(
       typeof(boilerplatetestWebCoreModule))]
    public class boilerplatetestWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public boilerplatetestWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boilerplatetestWebHostModule).GetAssembly());
        }
    }
}
