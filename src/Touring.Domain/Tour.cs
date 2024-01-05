using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Touring.Domain;
public class Tour : AuditedAggregateRoot<Guid>
{
    public string Name { set; get; }
    public List<Location> Locations { set; get; }
    public DateTime StartDate { set; get; }
}