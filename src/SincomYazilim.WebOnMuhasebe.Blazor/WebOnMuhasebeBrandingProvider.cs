using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SincomYazilim.WebOnMuhasebe.Blazor;

[Dependency(ReplaceServices = true)]
public class WebOnMuhasebeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "WebOnMuhasebe";
}
