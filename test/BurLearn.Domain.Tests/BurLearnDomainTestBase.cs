using Volo.Abp.Modularity;

namespace BurLearn;

/* Inherit from this class for your domain layer tests. */
public abstract class BurLearnDomainTestBase<TStartupModule> : BurLearnTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
