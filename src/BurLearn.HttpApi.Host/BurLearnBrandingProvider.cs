using Microsoft.Extensions.Localization;
using BurLearn.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BurLearn;

[Dependency(ReplaceServices = true)]
public class BurLearnBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BurLearnResource> _localizer;

    public BurLearnBrandingProvider(IStringLocalizer<BurLearnResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
