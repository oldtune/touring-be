using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Touring.EntityFrameworkCore;

public class TouringHttpApiHostMigrationsDbContext : AbpDbContext<TouringHttpApiHostMigrationsDbContext>
{
    public TouringHttpApiHostMigrationsDbContext(DbContextOptions<TouringHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureTouring();
    }
}
