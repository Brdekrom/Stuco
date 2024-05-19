namespace Stuco.Application.Abstractions;

public interface IPostHandler<TInput, TResult>
{
    Task<TResult> ExecuteAsync(TInput dto);
}