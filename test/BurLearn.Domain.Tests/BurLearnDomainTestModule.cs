using Volo.Abp.Modularity;

namespace BurLearn;

[DependsOn(
    typeof(BurLearnDomainModule),
    typeof(BurLearnTestBaseModule)
)]
public class BurLearnDomainTestModule : AbpModule
{

}
