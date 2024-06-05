using AutoMapper;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos;
using Stuco.Application.Dtos.Project;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Projects.Handlers;

internal class ProjectRequestHandler : IRequestHandler<DtoBase, Project>
{
    private readonly IRepository<Project> _repository;
    private readonly IMapper _mapper;

    public ProjectRequestHandler(IMapper mapper, IRepository<Project> repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<Project> Create(DtoBase dto)
    {
        var project = _mapper.Map<CreateProjectDto, Project>((CreateProjectDto)dto);
        await _repository.AddAsync(project);
        return project;
    }

    public async Task<bool> Delete(int id)
    {
        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<Project> Get(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Project>> GetAll()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<bool> Update(DtoBase dto)
    {
        var project = _mapper.Map<UpdateProjectDto, Project>((UpdateProjectDto)dto);
        await _repository.AddAsync(project);
        return true;
    }
}