using AutoMapper;
using Touring.Domain;

namespace Touring;

public class TouringApplicationAutoMapperProfile : Profile
{
    public TouringApplicationAutoMapperProfile()
    {
        CreateMap<TouringDto, Tour>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
