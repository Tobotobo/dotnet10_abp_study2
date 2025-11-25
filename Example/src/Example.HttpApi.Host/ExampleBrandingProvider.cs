using Microsoft.Extensions.Localization;
using Example.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Example;

[Dependency(ReplaceServices = true)]
public class ExampleBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ExampleResource> _localizer;

    public ExampleBrandingProvider(IStringLocalizer<ExampleResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
