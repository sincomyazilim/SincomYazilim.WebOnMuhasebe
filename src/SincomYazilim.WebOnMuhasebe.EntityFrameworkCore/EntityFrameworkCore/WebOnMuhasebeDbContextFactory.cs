using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class WebOnMuhasebeDbContextFactory : IDesignTimeDbContextFactory<WebOnMuhasebeDbContext>
{
    public WebOnMuhasebeDbContext CreateDbContext(string[] args)
    {
        WebOnMuhasebeEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<WebOnMuhasebeDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new WebOnMuhasebeDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SincomYazilim.WebOnMuhasebe.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
