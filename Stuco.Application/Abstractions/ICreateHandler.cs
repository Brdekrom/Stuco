namespace Stuco.Application.Abstractions;

public interface ICreateHandler<TInput, TResult>
{
    Task<TResult> ExecuteAsync(TInput dto);
}