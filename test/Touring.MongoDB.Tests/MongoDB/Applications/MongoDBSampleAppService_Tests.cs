using Touring.MongoDB;
using Touring.Samples;
using Xunit;

namespace Touring.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<TouringMongoDbTestModule>
{

}
