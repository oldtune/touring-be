using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Touring.MongoDB;

[ConnectionStringName(TouringDbProperties.ConnectionStringName)]
public class TouringMongoDbContext : AbpMongoDbContext, ITouringMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureTouring();
    }
}
