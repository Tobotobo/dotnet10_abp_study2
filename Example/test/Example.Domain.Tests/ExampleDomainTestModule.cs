using Volo.Abp.Modularity;

namespace Example;

[DependsOn(
    typeof(ExampleDomainModule),
    typeof(ExampleTestBaseModule)
)]
public class ExampleDomainTestModule : AbpModule
{

}
