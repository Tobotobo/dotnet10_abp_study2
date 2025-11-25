using Volo.Abp.Modularity;

namespace Example;

/* Inherit from this class for your domain layer tests. */
public abstract class ExampleDomainTestBase<TStartupModule> : ExampleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
