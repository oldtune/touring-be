using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Touring.EntityFrameworkCore;

[ConnectionStringName(TouringDbProperties.ConnectionStringName)]
public interface ITouringDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
