using AutoMapper;
using Stuco.Application.Dtos.Stukadoor;
using Stuco.Domain.Entities;

namespace Stuco.Application.Mappers;

public class StukadoorProfile : Profile
{
    public StukadoorProfile()
    {
        var config = new MapperConfiguration(cfg =>
        {
            CreateMap<CreateStukadoorDto, Stukadoor>();
            CreateMap<UpdateStukadoorDto, Stukadoor>();
        });
    }
}