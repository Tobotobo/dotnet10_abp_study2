using Example.Localization;
using Volo.Abp.Application.Services;

namespace Example;

/* Inherit your application services from this class.
 */
public abstract class ExampleAppService : ApplicationService
{
    protected ExampleAppService()
    {
        LocalizationResource = typeof(ExampleResource);
    }
}
