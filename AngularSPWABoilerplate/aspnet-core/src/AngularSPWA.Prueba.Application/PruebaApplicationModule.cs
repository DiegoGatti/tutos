using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AngularSPWA.Prueba.Authorization;

namespace AngularSPWA.Prueba
{
    [DependsOn(
        typeof(PruebaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PruebaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PruebaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PruebaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
