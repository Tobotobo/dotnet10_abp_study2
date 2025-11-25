using System.Threading.Tasks;

namespace Example.Data;

public interface IExampleDbSchemaMigrator
{
    Task MigrateAsync();
}
