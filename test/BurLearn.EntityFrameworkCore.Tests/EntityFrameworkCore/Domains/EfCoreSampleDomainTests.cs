using BurLearn.Samples;
using Xunit;

namespace BurLearn.EntityFrameworkCore.Domains;

[Collection(BurLearnTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BurLearnEntityFrameworkCoreTestModule>
{

}
