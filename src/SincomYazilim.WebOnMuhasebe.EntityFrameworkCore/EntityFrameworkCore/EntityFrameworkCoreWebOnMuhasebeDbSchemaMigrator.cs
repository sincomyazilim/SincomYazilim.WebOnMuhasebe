using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SincomYazilim.WebOnMuhasebe.Data;
using Volo.Abp.DependencyInjection;

namespace SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;

public class EntityFrameworkCoreWebOnMuhasebeDbSchemaMigrator
    : IWebOnMuhasebeDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreWebOnMuhasebeDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the WebOnMuhasebeDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<WebOnMuhasebeDbContext>()
            .Database
            .MigrateAsync();
    }
}
