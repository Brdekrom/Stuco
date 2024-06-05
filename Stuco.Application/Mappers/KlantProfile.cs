using AutoMapper;
using Stuco.Application.Dtos.Klant;
using Stuco.Domain.Entities;

namespace Stuco.Application.Mappers;

public class KlantProfile : Profile
{
    public KlantProfile()
    {
        var config = new MapperConfiguration(cfg =>
        {
            CreateMap<CreateKlantDto, Klant>();
            CreateMap<UpdateKlantDto, Klant>();
        });
    }
}