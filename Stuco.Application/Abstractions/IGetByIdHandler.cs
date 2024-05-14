namespace Stuco.Application.Abstractions;

public interface IGetByIdHandler<T>
{
    Task<T> ExecuteAsync(int id);
}