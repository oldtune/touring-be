using Touring.Samples;
using Xunit;

namespace Touring.EntityFrameworkCore.Applications;

[Collection(TouringTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TouringEntityFrameworkCoreTestModule>
{

}
