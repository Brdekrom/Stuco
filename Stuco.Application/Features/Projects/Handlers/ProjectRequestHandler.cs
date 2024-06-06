using AutoMapper;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos.Project;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Projects.Handlers;

internal class ProjectRequestHandler : IRequestHandler<DtoBase, ViewProjectDto>
{
    private readonly IRepository<Project> _repository;
    private readonly IMapper _mapper;

    public ProjectRequestHandler(IMapper mapper, IRepository<Project> repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<ViewProjectDto> Create(DtoBase dto)
    {
        var project = _mapper.Map<CreateProjectDto, Project>((CreateProjectDto)dto);
        await _repository.AddAsync(project);
        return _mapper.Map<ViewProjectDto>(project);
    }

    public async Task<bool> Delete(int id)
    {
        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<ViewProjectDto> Get(int id)
    {
        var project = await _repository.GetByIdAsync(id);
        return _mapper.Map<ViewProjectDto>(project);
    }

    public async Task<IEnumerable<ViewProjectDto>> GetAll()
    {
        var project = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<ViewProjectDto>>(project);
    }

    public async Task<bool> Update(DtoBase dto)
    {
        var project = _mapper.Map<UpdateProjectDto, Project>((UpdateProjectDto)dto);
        await _repository.AddAsync(project);
        return true;
    }
}