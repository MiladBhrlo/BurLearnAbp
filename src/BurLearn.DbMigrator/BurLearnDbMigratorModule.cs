using BurLearn.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BurLearn.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BurLearnEntityFrameworkCoreModule),
    typeof(BurLearnApplicationContractsModule)
)]
public class BurLearnDbMigratorModule : AbpModule
{
}
