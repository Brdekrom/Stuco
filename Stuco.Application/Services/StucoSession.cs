using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Services;

public class StucoSession(IRepository repository) : ISession
{
    public Contractor GetCurrentContractor()
    {
        var contractor = repository.Contractors.Single();
        return contractor;
    }
}