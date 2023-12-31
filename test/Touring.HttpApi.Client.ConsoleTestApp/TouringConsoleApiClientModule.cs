using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Touring;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TouringHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class TouringConsoleApiClientModule : AbpModule
{

}
