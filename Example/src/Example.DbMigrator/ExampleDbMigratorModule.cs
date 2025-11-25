using Example.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Example.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ExampleEntityFrameworkCoreModule),
    typeof(ExampleApplicationContractsModule)
)]
public class ExampleDbMigratorModule : AbpModule
{
}
