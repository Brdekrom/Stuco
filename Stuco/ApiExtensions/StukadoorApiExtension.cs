using Stuco.Application.Features.Stukadoren.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Api.ApiExtensions;

internal static class StukadoorApiExtension
{
    private const string BaseUrl = "/stukadoor";

    internal static void MapStukadoorEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(BaseUrl, (IGetAllStukadoren getAllStucadoren) =>
        {
            return getAllStucadoren.Execute();
        });

        endpoints.MapGet("{BaseUrl}/{id:int}", (int id, IGetStukadoor getStukadoor) =>
        {
            return getStukadoor.Execute(id);
        });

        endpoints.MapPost(BaseUrl, (Stukadoor stukadoor, ICreateStukadoor createStukadoor) =>
        {
            return createStukadoor.Execute(stukadoor);
        });
    }
}