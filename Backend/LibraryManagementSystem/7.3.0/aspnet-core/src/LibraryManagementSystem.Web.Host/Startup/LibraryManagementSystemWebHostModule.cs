using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryManagementSystem.Configuration;

namespace LibraryManagementSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(LibraryManagementSystemWebCoreModule))]
    public class LibraryManagementSystemWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LibraryManagementSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryManagementSystemWebHostModule).GetAssembly());
        }
    }
}
