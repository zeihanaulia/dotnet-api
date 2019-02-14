using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using dotnet-api.Configuration;
using dotnet-api.Web;

namespace dotnet-api.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class dotnet-apiDbContextFactory : IDesignTimeDbContextFactory<dotnet-apiDbContext>
    {
        public dotnet-apiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<dotnet-apiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            dotnet-apiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(dotnet-apiConsts.ConnectionStringName));

            return new dotnet-apiDbContext(builder.Options);
        }
    }
}
