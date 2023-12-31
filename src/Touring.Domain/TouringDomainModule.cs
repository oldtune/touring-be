using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Touring;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(TouringDomainSharedModule)
)]
public class TouringDomainModule : AbpModule
{

}
