using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Touring;
public class TouringDto : ExtensibleAuditedEntityDto<Guid>
{
    public string Name { set; get; }
    public List<LocationDto> Locations { set; get; }
    public DateTime StartDate { set; get; }

    public TouringDto()
    {
        Locations = new List<LocationDto>();
    }
}

public class LocationDto
{
    public string Lat { set; get; }
    public string Long { set; get; }
    public string Name { set; get; }
}