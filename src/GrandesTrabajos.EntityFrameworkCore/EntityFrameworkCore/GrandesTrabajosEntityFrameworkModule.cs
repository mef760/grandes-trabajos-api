using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using GrandesTrabajos.EntityFrameworkCore.Seed;

namespace GrandesTrabajos.EntityFrameworkCore
{
    [DependsOn(
        typeof(GrandesTrabajosCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class GrandesTrabajosEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<GrandesTrabajosDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        GrandesTrabajosDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        GrandesTrabajosDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GrandesTrabajosEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
