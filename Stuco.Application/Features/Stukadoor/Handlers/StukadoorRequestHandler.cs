using AutoMapper;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos.Stukadoor;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Stukadoors.Handlers;

internal class StukadoorRequestHandler : IRequestHandler<DtoBase, ViewStukadoorDto>
{
    private readonly IRepository<Stukadoor> _repository;
    private readonly IMapper _mapper;

    public StukadoorRequestHandler(IMapper mapper, IRepository<Stukadoor> repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<ViewStukadoorDto> Create(DtoBase dto)
    {
        var stukadoor = _mapper.Map<CreateStukadoorDto, Stukadoor>((CreateStukadoorDto)dto);
        await _repository.AddAsync(stukadoor);
        return _mapper.Map<ViewStukadoorDto>(stukadoor);
    }

    public async Task<bool> Delete(int id)
    {
        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<ViewStukadoorDto> Get(int id)
    {
        var stukadoor = await _repository.GetByIdAsync(id);
        return _mapper.Map<ViewStukadoorDto>(stukadoor);
    }

    public async Task<IEnumerable<ViewStukadoorDto>> GetAll()
    {
        var stukadoren = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<ViewStukadoorDto>>(stukadoren);
    }

    public async Task<bool> Update(DtoBase dto)
    {
        var stukadoor = _mapper.Map<UpdateStukadoorDto, Stukadoor>((UpdateStukadoorDto)dto);
        await _repository.AddAsync(stukadoor);
        return true;
    }
}