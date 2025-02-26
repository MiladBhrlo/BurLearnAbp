﻿using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BurLearn.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BurLearnDbContextFactory : IDesignTimeDbContextFactory<BurLearnDbContext>
{
    public BurLearnDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        BurLearnEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<BurLearnDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new BurLearnDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BurLearn.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
