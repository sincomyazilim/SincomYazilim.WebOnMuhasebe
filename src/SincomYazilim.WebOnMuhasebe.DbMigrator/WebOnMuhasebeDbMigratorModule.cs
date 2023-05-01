using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SincomYazilim.WebOnMuhasebe.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WebOnMuhasebeEntityFrameworkCoreModule),
    typeof(WebOnMuhasebeApplicationContractsModule)
    )]
public class WebOnMuhasebeDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
