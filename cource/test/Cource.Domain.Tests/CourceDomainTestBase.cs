using Volo.Abp.Modularity;

namespace Cource;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class CourceDomainTestBase<TStartupModule> : CourceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
