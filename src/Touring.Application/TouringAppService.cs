using Touring.Localization;
using Volo.Abp.Application.Services;

namespace Touring;

public abstract class TouringAppService : ApplicationService
{
    protected TouringAppService()
    {
        LocalizationResource = typeof(TouringResource);
        ObjectMapperContext = typeof(TouringApplicationModule);
    }
}
