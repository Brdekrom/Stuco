using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Features.Stukadoren.Handlers;

public class GetStukadoorHandler : IGetHandler<List<Stukadoor>>
{
    public async Task<List<Stukadoor>> ExecuteAsync()
    {
        return new List<Stukadoor>();
    }
}