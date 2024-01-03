using Touring.Samples;
using Xunit;

namespace Touring.EntityFrameworkCore.Domains;

[Collection(TouringTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TouringEntityFrameworkCoreTestModule>
{

}
