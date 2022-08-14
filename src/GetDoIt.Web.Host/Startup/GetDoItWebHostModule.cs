﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GetDoIt.Configuration;

namespace GetDoIt.Web.Host.Startup
{
    [DependsOn(
       typeof(GetDoItWebCoreModule))]
    public class GetDoItWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GetDoItWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GetDoItWebHostModule).GetAssembly());
        }
    }
}
