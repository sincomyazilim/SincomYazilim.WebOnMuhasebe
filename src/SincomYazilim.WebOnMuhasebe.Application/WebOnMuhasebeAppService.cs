using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Localization;
using Volo.Abp.Application.Services;

namespace SincomYazilim.WebOnMuhasebe;

/* Inherit your application services from this class.
 */
public abstract class WebOnMuhasebeAppService : ApplicationService
{
    protected WebOnMuhasebeAppService()
    {
        LocalizationResource = typeof(WebOnMuhasebeResource);
    }
}
