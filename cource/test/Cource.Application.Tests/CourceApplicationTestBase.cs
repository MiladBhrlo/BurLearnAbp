using Volo.Abp.Modularity;

namespace Cource;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class CourceApplicationTestBase<TStartupModule> : CourceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
