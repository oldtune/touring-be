using Volo.Abp.Modularity;

namespace Touring;

/* Inherit from this class for your domain layer tests. */
public abstract class TouringDomainTestBase<TStartupModule> : TouringTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
