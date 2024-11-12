using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Cource.EntityFrameworkCore;

[ConnectionStringName(CourceDbProperties.ConnectionStringName)]
public class CourceDbContext : AbpDbContext<CourceDbContext>, ICourceDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public CourceDbContext(DbContextOptions<CourceDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureCource();
    }
}
