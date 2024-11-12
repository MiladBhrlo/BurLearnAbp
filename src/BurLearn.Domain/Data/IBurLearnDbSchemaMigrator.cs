using System.Threading.Tasks;

namespace BurLearn.Data;

public interface IBurLearnDbSchemaMigrator
{
    Task MigrateAsync();
}
