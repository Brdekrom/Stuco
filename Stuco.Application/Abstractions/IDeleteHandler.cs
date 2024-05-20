namespace Stuco.Application.Abstractions;

public interface IDeleteHandler<T>
{
    Task<bool> ExecuteAsync(int id);
}