using BurLearn.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BurLearn.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BurLearnController : AbpControllerBase
{
    protected BurLearnController()
    {
        LocalizationResource = typeof(BurLearnResource);
    }
}
