using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dotnet-api.Configuration;

namespace dotnet-api.Web.Host.Startup
{
    [DependsOn(
       typeof(dotnet-apiWebCoreModule))]
    public class dotnet-apiWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public dotnet-apiWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(dotnet-apiWebHostModule).GetAssembly());
        }
    }
}
