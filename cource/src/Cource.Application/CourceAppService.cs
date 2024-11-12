using Cource.Localization;
using Volo.Abp.Application.Services;

namespace Cource;

public abstract class CourceAppService : ApplicationService
{
    protected CourceAppService()
    {
        LocalizationResource = typeof(CourceResource);
        ObjectMapperContext = typeof(CourceApplicationModule);
    }
}
