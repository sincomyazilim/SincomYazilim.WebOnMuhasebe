using SincomYazilim.WebOnMuhasebe.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SincomYazilim.WebOnMuhasebe.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class WebOnMuhasebeController : AbpControllerBase
{
    protected WebOnMuhasebeController()
    {
        LocalizationResource = typeof(WebOnMuhasebeResource);
    }
}
