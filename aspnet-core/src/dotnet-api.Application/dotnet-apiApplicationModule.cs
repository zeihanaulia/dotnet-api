using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dotnet-api.Authorization;

namespace dotnet-api
{
    [DependsOn(
        typeof(dotnet-apiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class dotnet-apiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<dotnet-apiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(dotnet-apiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
