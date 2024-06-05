using AutoMapper;
using Stuco.Application.Dtos.Project;
using Stuco.Domain.Entities;

namespace Stuco.Application.Mappers;

public class ProjectProfile : Profile
{
    public ProjectProfile()
    {
        var config = new MapperConfiguration(cfg =>
        {
            CreateMap<CreateProjectDto, Project>();
            CreateMap<UpdateProjectDto, Project>();
        });
    }
}