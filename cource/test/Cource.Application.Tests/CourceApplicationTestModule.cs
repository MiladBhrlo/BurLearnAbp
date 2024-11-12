using Volo.Abp.Modularity;

namespace Cource;

[DependsOn(
    typeof(CourceApplicationModule),
    typeof(CourceDomainTestModule)
    )]
public class CourceApplicationTestModule : AbpModule
{

}
