namespace Stuco.Application.Abstractions;

public interface IUpdateHandler<T>
{
    Task<bool> ExecuteAsync(T dto);
}