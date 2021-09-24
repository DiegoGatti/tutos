using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AngularSPWA.Prueba.EntityFrameworkCore;
using AngularSPWA.Prueba.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AngularSPWA.Prueba.Web.Tests
{
    [DependsOn(
        typeof(PruebaWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PruebaWebTestModule : AbpModule
    {
        public PruebaWebTestModule(PruebaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PruebaWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PruebaWebMvcModule).Assembly);
        }
    }
}