using Volo.Abp.Modularity;

namespace Example;

[DependsOn(
    typeof(ExampleApplicationModule),
    typeof(ExampleDomainTestModule)
)]
public class ExampleApplicationTestModule : AbpModule
{

}
