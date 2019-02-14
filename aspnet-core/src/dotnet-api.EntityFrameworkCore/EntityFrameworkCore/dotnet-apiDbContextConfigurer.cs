using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace dotnet-api.EntityFrameworkCore
{
    public static class dotnet-apiDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<dotnet-apiDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<dotnet-apiDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
