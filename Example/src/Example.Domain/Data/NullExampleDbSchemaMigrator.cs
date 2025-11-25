using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Example.Data;

/* This is used if database provider does't define
 * IExampleDbSchemaMigrator implementation.
 */
public class NullExampleDbSchemaMigrator : IExampleDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
