using Volo.Abp.Modularity;

namespace Touring;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class TouringApplicationTestBase<TStartupModule> : TouringTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
