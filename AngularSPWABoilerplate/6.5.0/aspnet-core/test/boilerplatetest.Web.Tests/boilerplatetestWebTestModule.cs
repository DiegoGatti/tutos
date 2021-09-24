using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplatetest.EntityFrameworkCore;
using boilerplatetest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace boilerplatetest.Web.Tests
{
    [DependsOn(
        typeof(boilerplatetestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class boilerplatetestWebTestModule : AbpModule
    {
        public boilerplatetestWebTestModule(boilerplatetestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boilerplatetestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(boilerplatetestWebMvcModule).Assembly);
        }
    }
}