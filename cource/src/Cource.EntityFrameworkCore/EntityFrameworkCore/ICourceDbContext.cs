using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Cource.EntityFrameworkCore;

[ConnectionStringName(CourceDbProperties.ConnectionStringName)]
public interface ICourceDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
