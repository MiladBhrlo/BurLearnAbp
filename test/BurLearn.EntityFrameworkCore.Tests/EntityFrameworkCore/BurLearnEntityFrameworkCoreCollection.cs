using Xunit;

namespace BurLearn.EntityFrameworkCore;

[CollectionDefinition(BurLearnTestConsts.CollectionDefinitionName)]
public class BurLearnEntityFrameworkCoreCollection : ICollectionFixture<BurLearnEntityFrameworkCoreFixture>
{

}
