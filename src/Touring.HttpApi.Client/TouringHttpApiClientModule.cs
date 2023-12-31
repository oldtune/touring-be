using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Touring;

[DependsOn(
    typeof(TouringApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class TouringHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(TouringApplicationContractsModule).Assembly,
            TouringRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<TouringHttpApiClientModule>();
        });

    }
}
