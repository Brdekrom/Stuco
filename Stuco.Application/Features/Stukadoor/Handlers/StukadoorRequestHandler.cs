using AutoMapper;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos;
using Stuco.Application.Dtos.Stukadoor;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Stukadoors.Handlers;

internal class StukadoorRequestHandler : IRequestHandler<DtoBase, Stukadoor>
{
    private readonly IRepository<Stukadoor> _repository;
    private readonly IMapper _mapper;

    public StukadoorRequestHandler(IMapper mapper, IRepository<Stukadoor> repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<Stukadoor> Create(DtoBase dto)
    {
        var stukadoor = _mapper.Map<CreateStukadoorDto, Stukadoor>((CreateStukadoorDto)dto);
        await _repository.AddAsync(stukadoor);
        return stukadoor;
    }

    public async Task<bool> Delete(int id)
    {
        await _repository.DeleteAsync(id);
        return true;
    }

    public async Task<Stukadoor> Get(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Stukadoor>> GetAll()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<bool> Update(DtoBase dto)
    {
        var stukadoor = _mapper.Map<UpdateStukadoorDto, Stukadoor>((UpdateStukadoorDto)dto);
        await _repository.AddAsync(stukadoor);
        return true;
    }
}