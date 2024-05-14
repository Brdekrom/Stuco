namespace Stuco.Application.Features.Stukadoren.Abstractions;

public interface IRequestHandler<T>
{
    Task<T> Execute();
}