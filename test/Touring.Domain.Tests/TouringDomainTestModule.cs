using Volo.Abp.Modularity;

namespace Touring;

[DependsOn(
    typeof(TouringDomainModule),
    typeof(TouringTestBaseModule)
)]
public class TouringDomainTestModule : AbpModule
{

}
