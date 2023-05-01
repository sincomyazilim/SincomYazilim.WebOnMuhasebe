using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SincomYazilim.WebOnMuhasebe;

[DependsOn(
    typeof(WebOnMuhasebeEntityFrameworkCoreTestModule)
    )]
public class WebOnMuhasebeDomainTestModule : AbpModule
{

}
