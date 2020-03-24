using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HoanAM.Configuration;

namespace HoanAM.Web.Host.Startup
{
    [DependsOn(
       typeof(HoanAMWebCoreModule))]
    public class HoanAMWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HoanAMWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HoanAMWebHostModule).GetAssembly());
        }
    }
}
