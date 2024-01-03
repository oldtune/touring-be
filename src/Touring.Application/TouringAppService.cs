using System;
using System.Collections.Generic;
using System.Text;
using Touring.Localization;
using Volo.Abp.Application.Services;

namespace Touring;

/* Inherit your application services from this class.
 */
public abstract class TouringAppService : ApplicationService
{
    protected TouringAppService()
    {
        LocalizationResource = typeof(TouringResource);
    }
}
