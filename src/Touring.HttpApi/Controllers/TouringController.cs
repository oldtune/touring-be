using Touring.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Touring.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TouringController : AbpControllerBase
{
    protected TouringController()
    {
        LocalizationResource = typeof(TouringResource);
    }
}
