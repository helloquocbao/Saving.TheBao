using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GetDoIt.EntityFrameworkCore;
using GetDoIt.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace GetDoIt.Web.Tests
{
    [DependsOn(
        typeof(GetDoItWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GetDoItWebTestModule : AbpModule
    {
        public GetDoItWebTestModule(GetDoItEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GetDoItWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GetDoItWebMvcModule).Assembly);
        }
    }
}