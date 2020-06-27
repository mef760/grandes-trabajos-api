using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GrandesTrabajos.EntityFrameworkCore;
using GrandesTrabajos.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace GrandesTrabajos.Web.Tests
{
    [DependsOn(
        typeof(GrandesTrabajosWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GrandesTrabajosWebTestModule : AbpModule
    {
        public GrandesTrabajosWebTestModule(GrandesTrabajosEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GrandesTrabajosWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GrandesTrabajosWebMvcModule).Assembly);
        }
    }
}