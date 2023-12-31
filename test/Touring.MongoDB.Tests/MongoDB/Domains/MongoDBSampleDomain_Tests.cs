using Touring.Samples;
using Xunit;

namespace Touring.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<TouringMongoDbTestModule>
{

}
