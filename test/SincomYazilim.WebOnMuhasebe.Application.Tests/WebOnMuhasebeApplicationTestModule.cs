using Volo.Abp.Modularity;

namespace SincomYazilim.WebOnMuhasebe;

[DependsOn(
    typeof(WebOnMuhasebeApplicationModule),
    typeof(WebOnMuhasebeDomainTestModule)
    )]
public class WebOnMuhasebeApplicationTestModule : AbpModule
{

}
