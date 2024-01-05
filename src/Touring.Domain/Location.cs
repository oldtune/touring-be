using System;
using Volo.Abp.Domain.Entities;

namespace Touring.Domain;
public class Location : Entity<Guid>
{
    public string Lat { set; get; }
    public string Long { set; get; }
    public string Name { set; get; }
}