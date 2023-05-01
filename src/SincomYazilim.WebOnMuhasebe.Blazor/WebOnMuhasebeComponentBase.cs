using SincomYazilim.WebOnMuhasebe.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SincomYazilim.WebOnMuhasebe.Blazor;

public abstract class WebOnMuhasebeComponentBase : AbpComponentBase
{
    protected WebOnMuhasebeComponentBase()
    {
        LocalizationResource = typeof(WebOnMuhasebeResource);
    }
}
