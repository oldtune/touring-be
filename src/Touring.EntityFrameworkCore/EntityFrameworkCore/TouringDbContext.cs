using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Touring.EntityFrameworkCore;

[ConnectionStringName(TouringDbProperties.ConnectionStringName)]
public class TouringDbContext : AbpDbContext<TouringDbContext>, ITouringDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public TouringDbContext(DbContextOptions<TouringDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureTouring();
    }
}
