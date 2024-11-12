using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BurLearn.Data;

/* This is used if database provider does't define
 * IBurLearnDbSchemaMigrator implementation.
 */
public class NullBurLearnDbSchemaMigrator : IBurLearnDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
