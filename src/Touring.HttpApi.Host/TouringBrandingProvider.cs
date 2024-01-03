using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Touring;

[Dependency(ReplaceServices = true)]
public class TouringBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Touring";
}
