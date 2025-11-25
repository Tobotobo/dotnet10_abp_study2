using Example.Samples;
using Xunit;

namespace Example.EntityFrameworkCore.Domains;

[Collection(ExampleTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ExampleEntityFrameworkCoreTestModule>
{

}
