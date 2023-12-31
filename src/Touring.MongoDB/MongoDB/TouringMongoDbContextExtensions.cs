using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Touring.MongoDB;

public static class TouringMongoDbContextExtensions
{
    public static void ConfigureTouring(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
