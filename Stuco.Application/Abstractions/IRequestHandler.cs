namespace Stuco.Application.Abstractions;

public interface IRequestHandler<T>
{
    Task<T> Execute();
}