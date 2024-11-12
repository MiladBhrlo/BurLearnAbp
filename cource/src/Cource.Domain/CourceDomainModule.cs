using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Cource;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CourceDomainSharedModule)
)]
public class CourceDomainModule : AbpModule
{

}
