using BurLearn.Books;
using Xunit;

namespace BurLearn.EntityFrameworkCore.Applications.Books;

[Collection(BurLearnTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<BurLearnEntityFrameworkCoreTestModule>
{

}