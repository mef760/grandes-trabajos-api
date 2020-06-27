using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using GrandesTrabajos.Configuration;
using GrandesTrabajos.Web;

namespace GrandesTrabajos.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GrandesTrabajosDbContextFactory : IDesignTimeDbContextFactory<GrandesTrabajosDbContext>
    {
        public GrandesTrabajosDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GrandesTrabajosDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GrandesTrabajosDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GrandesTrabajosConsts.ConnectionStringName));

            return new GrandesTrabajosDbContext(builder.Options);
        }
    }
}
