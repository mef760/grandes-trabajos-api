using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GrandesTrabajos.EntityFrameworkCore
{
    public static class GrandesTrabajosDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GrandesTrabajosDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GrandesTrabajosDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
