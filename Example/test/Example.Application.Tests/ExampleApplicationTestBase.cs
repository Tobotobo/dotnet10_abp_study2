using Volo.Abp.Modularity;

namespace Example;

public abstract class ExampleApplicationTestBase<TStartupModule> : ExampleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
