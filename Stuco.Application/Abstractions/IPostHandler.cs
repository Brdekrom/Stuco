namespace Stuco.Application.Abstractions;

public interface IPostHandler<T>
{
    Task<T> Execute(T dto);
}