using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Touring;

[DependsOn(
    typeof(TouringDomainModule),
    typeof(TouringApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class TouringApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<TouringApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<TouringApplicationModule>(validate: true);
        });
    }
}
