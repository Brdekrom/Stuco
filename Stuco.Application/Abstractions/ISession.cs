using Stuco.Domain.Entities;

namespace Stuco.Application.Abstractions;

public interface ISession
{
    public Contractor GetCurrentContractor();
}