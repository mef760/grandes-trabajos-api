using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GrandesTrabajos.Authorization.Roles;
using GrandesTrabajos.Authorization.Users;
using GrandesTrabajos.MultiTenancy;

namespace GrandesTrabajos.EntityFrameworkCore
{
    public class GrandesTrabajosDbContext : AbpZeroDbContext<Tenant, Role, User, GrandesTrabajosDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GrandesTrabajosDbContext(DbContextOptions<GrandesTrabajosDbContext> options)
            : base(options)
        {
        }
    }
}
