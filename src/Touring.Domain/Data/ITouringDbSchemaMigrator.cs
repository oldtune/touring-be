using System.Threading.Tasks;

namespace Touring.Data;

public interface ITouringDbSchemaMigrator
{
    Task MigrateAsync();
}
