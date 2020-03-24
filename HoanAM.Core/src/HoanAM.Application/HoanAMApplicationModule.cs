using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HoanAM.Authorization;

namespace HoanAM
{
    [DependsOn(
        typeof(HoanAMCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HoanAMApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HoanAMAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HoanAMApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
