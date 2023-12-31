using Volo.Abp.Modularity;

namespace Touring;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class TouringDomainTestBase<TStartupModule> : TouringTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
