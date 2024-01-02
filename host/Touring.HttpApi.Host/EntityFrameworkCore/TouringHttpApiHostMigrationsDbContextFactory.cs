using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Touring.EntityFrameworkCore;

public class TouringHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<TouringHttpApiHostMigrationsDbContext>
{
    public TouringHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TouringHttpApiHostMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("Touring"));

        return new TouringHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
