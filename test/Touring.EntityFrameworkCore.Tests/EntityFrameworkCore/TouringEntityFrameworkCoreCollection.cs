using Xunit;

namespace Touring.EntityFrameworkCore;

[CollectionDefinition(TouringTestConsts.CollectionDefinitionName)]
public class TouringEntityFrameworkCoreCollection : ICollectionFixture<TouringEntityFrameworkCoreFixture>
{

}
