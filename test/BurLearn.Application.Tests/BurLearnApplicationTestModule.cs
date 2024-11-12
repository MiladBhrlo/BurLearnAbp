using Volo.Abp.Modularity;

namespace BurLearn;

[DependsOn(
    typeof(BurLearnApplicationModule),
    typeof(BurLearnDomainTestModule)
)]
public class BurLearnApplicationTestModule : AbpModule
{

}
