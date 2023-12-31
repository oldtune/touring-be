using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Touring;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class TouringInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<TouringInstallerModule>();
        });
    }
}
