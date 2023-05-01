using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SincomYazilim.WebOnMuhasebe.Data;

/* This is used if database provider does't define
 * IWebOnMuhasebeDbSchemaMigrator implementation.
 */
public class NullWebOnMuhasebeDbSchemaMigrator : IWebOnMuhasebeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
