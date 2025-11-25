using Xunit;

namespace Example.EntityFrameworkCore;

[CollectionDefinition(ExampleTestConsts.CollectionDefinitionName)]
public class ExampleEntityFrameworkCoreCollection : ICollectionFixture<ExampleEntityFrameworkCoreFixture>
{

}
