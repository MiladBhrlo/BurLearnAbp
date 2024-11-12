using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BurLearn.Data;
using Volo.Abp.DependencyInjection;

namespace BurLearn.EntityFrameworkCore;

public class EntityFrameworkCoreBurLearnDbSchemaMigrator
    : IBurLearnDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBurLearnDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BurLearnDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BurLearnDbContext>()
            .Database
            .MigrateAsync();
    }
}
