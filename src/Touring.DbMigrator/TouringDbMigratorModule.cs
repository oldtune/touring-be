using Touring.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Touring.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TouringEntityFrameworkCoreModule),
    typeof(TouringApplicationContractsModule)
    )]
public class TouringDbMigratorModule : AbpModule
{
}
