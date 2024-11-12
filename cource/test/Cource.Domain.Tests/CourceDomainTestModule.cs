using Volo.Abp.Modularity;

namespace Cource;

[DependsOn(
    typeof(CourceDomainModule),
    typeof(CourceTestBaseModule)
)]
public class CourceDomainTestModule : AbpModule
{

}
