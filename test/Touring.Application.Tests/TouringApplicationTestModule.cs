using Volo.Abp.Modularity;

namespace Touring;

[DependsOn(
    typeof(TouringApplicationModule),
    typeof(TouringDomainTestModule)
)]
public class TouringApplicationTestModule : AbpModule
{

}
