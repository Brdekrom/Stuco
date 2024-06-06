namespace Stuco.Application.Abstractions;

public interface IRequestHandler<TIn, TOut> where TOut : DtoBase
{
    Task<TOut> Create(TIn dto);

    Task<bool> Update(TIn dto);

    Task<bool> Delete(int id);

    Task<TOut> Get(int id);

    Task<IEnumerable<TOut>> GetAll();
}