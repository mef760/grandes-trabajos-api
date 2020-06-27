using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GrandesTrabajos.Authorization;

namespace GrandesTrabajos
{
    [DependsOn(
        typeof(GrandesTrabajosCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GrandesTrabajosApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GrandesTrabajosAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GrandesTrabajosApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
