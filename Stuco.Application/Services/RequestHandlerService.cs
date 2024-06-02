using Stuco.Application.Abstractions;

namespace Stuco.Application.Services;

public class RequestHandlerService : IRequestHandlerService
{
    // TODO
    //TODO: Add an repository to the constructor
    //Maybe a UnitOfWork
    public RequestHandlerService()
    {
    }

    public async Task<T> GetById<T>(IGetByIdHandler<T> handler, int id)
    {
        // Query the database and return the entity

        throw new NotImplementedException();
    }

    public async Task<T> GetT<T>(IGetHandler<T> handler)
    {
        // Query the database and return the entities

        throw new NotImplementedException();
    }

    public async Task<T> Post<T>(ICreateHandler<T, T> handler, T dto)
    {
        // Map the Dto to the entity
        // Save the entity to the database
        // Map the entity back to the Dto
        // Return the entity

        throw new NotImplementedException();
    }

    public async Task<bool> Put<T>(IUpdateHandler<T> handler, T dto)
    {
        return await handler.ExecuteAsync(entity);
    }

    public async Task<bool> Delete<T>(IDeleteHandler<T> handler, int id)
    {
        return await handler.ExecuteAsync(id);
    }
}