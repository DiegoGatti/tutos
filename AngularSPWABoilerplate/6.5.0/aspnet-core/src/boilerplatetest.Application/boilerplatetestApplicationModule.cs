using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplatetest.Authorization;

namespace boilerplatetest
{
    [DependsOn(
        typeof(boilerplatetestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class boilerplatetestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<boilerplatetestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(boilerplatetestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
