namespace Stuco.Application.Abstractions;

public interface IGetHandler<T>
{
    Task<T> ExecuteAsync();
}