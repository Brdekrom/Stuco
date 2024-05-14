namespace Stuco.Application.Abstractions;

public interface IGetByIdHandler<T>
{
    Task<T> Execute(int id);
}