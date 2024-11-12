using Volo.Abp.Modularity;

namespace BurLearn;

public abstract class BurLearnApplicationTestBase<TStartupModule> : BurLearnTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
