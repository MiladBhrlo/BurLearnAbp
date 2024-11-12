using BurLearn.Localization;
using Volo.Abp.Application.Services;

namespace BurLearn;

/* Inherit your application services from this class.
 */
public abstract class BurLearnAppService : ApplicationService
{
    protected BurLearnAppService()
    {
        LocalizationResource = typeof(BurLearnResource);
    }
}
