using System;
using Microsoft.Extensions.Logging;
using Touring.Domain;
using Touring.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Touring;

/* Inherit your application services from this class.
 */
public abstract class TouringAppService : CrudAppService<Tour, TouringDto, Guid>, ITouringAppService
{
    private readonly IObjectMapper<TouringApplicationModule> _objectMapper;
    private readonly ILogger<TouringAppService> _logger;

    public TouringAppService(ILogger<TouringAppService> logger, IRepository<Tour, Guid> touringRepository) : base(touringRepository)
    {
        _logger = logger!;
    }

    protected TouringAppService(IRepository<Tour, Guid> touringRepository) : base(touringRepository)
    {
        LocalizationResource = typeof(TouringResource);
    }
}
