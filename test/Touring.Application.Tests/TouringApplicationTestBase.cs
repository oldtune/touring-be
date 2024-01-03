using Volo.Abp.Modularity;

namespace Touring;

public abstract class TouringApplicationTestBase<TStartupModule> : TouringTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
