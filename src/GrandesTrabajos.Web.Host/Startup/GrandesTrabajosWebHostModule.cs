using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GrandesTrabajos.Configuration;

namespace GrandesTrabajos.Web.Host.Startup
{
    [DependsOn(
       typeof(GrandesTrabajosWebCoreModule))]
    public class GrandesTrabajosWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GrandesTrabajosWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GrandesTrabajosWebHostModule).GetAssembly());
        }
    }
}
