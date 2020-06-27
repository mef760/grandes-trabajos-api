using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GrandesTrabajos.Configuration;
using GrandesTrabajos.EntityFrameworkCore;
using GrandesTrabajos.Migrator.DependencyInjection;

namespace GrandesTrabajos.Migrator
{
    [DependsOn(typeof(GrandesTrabajosEntityFrameworkModule))]
    public class GrandesTrabajosMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public GrandesTrabajosMigratorModule(GrandesTrabajosEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(GrandesTrabajosMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                GrandesTrabajosConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GrandesTrabajosMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
