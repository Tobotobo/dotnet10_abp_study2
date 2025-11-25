using Example.Samples;
using Xunit;

namespace Example.EntityFrameworkCore.Applications;

[Collection(ExampleTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ExampleEntityFrameworkCoreTestModule>
{

}
