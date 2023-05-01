using System.Threading.Tasks;

namespace SincomYazilim.WebOnMuhasebe.Data;

public interface IWebOnMuhasebeDbSchemaMigrator
{
    Task MigrateAsync();
}
