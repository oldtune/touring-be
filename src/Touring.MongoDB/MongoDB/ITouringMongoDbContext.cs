using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Touring.MongoDB;

[ConnectionStringName(TouringDbProperties.ConnectionStringName)]
public interface ITouringMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
