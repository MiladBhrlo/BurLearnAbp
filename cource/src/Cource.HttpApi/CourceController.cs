using Cource.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cource;

public abstract class CourceController : AbpControllerBase
{
    protected CourceController()
    {
        LocalizationResource = typeof(CourceResource);
    }
}
