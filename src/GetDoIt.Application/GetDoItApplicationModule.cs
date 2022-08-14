using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GetDoIt.Authorization;

namespace GetDoIt
{
    [DependsOn(
        typeof(GetDoItCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GetDoItApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GetDoItAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GetDoItApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            //Configuration.Modules.AbpAutoMapper().Configurators.Add(
            //    // Scan the assembly for classes which inherit from AutoMapper.Profile
            //    cfg => cfg.AddMaps(thisAssembly)
            //);
        }
    }
}
