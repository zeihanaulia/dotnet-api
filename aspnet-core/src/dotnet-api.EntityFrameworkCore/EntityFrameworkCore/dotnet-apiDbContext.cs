using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using dotnet-api.Authorization.Roles;
using dotnet-api.Authorization.Users;
using dotnet-api.MultiTenancy;

namespace dotnet-api.EntityFrameworkCore
{
    public class dotnet-apiDbContext : AbpZeroDbContext<Tenant, Role, User, dotnet-apiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public dotnet-apiDbContext(DbContextOptions<dotnet-apiDbContext> options)
            : base(options)
        {
        }
    }
}
