using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Touring.Data;

/* This is used if database provider does't define
 * ITouringDbSchemaMigrator implementation.
 */
public class NullTouringDbSchemaMigrator : ITouringDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
