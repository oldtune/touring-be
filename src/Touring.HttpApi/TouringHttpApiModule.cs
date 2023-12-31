using Localization.Resources.AbpUi;
using Touring.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Touring;

[DependsOn(
    typeof(TouringApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class TouringHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(TouringHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<TouringResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
