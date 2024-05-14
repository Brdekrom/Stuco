namespace Stuco.Application.Abstractions;

public interface IPostHandler<T>
{
    Task<T> ExecuteAsync(T dto);
}