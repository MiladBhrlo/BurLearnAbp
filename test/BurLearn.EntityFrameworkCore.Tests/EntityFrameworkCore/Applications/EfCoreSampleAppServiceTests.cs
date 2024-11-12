using BurLearn.Samples;
using Xunit;

namespace BurLearn.EntityFrameworkCore.Applications;

[Collection(BurLearnTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BurLearnEntityFrameworkCoreTestModule>
{

}
