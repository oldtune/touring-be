using Touring.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Touring;

public abstract class TouringController : AbpControllerBase
{
    protected TouringController()
    {
        LocalizationResource = typeof(TouringResource);
    }
}
