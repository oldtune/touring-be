using System;
using Volo.Abp.Application.Services;

namespace Touring;
public interface ITouringAppService : ICrudAppService<TouringDto, Guid>
{
}