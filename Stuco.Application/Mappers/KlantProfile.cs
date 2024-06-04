using AutoMapper;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;

namespace Stuco.Application.Mappers;

public class KlantProfile : Profile
{
    public KlantProfile()
    {
        var config = new MapperConfiguration(cfg =>
        {
            CreateMap<KlantDto, Klant>();
        });

    }
}