namespace Stuco.Application.Abstractions;

public interface IRequestHandlerService
{
    public Task<T> GetT<T>(IGetHandler<T> handler);

    public Task<T> GetById<T>(IGetByIdHandler<T> handler, int id);

    public Task<T> Post<T>(ICreateHandler<T, T> handler, T entity);

    public Task<bool> Put<T>(IUpdateHandler<T> handler, T entity);

    public Task<bool> Delete<T>(IDeleteHandler<T> handler, int id);
}