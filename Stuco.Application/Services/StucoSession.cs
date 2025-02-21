using Microsoft.EntityFrameworkCore;
using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Services;

public class StucoSession(IRepository repository) : ISession
{
    public Contractor GetCurrentContractor()
    {
        var contractor = repository.Contractors
            .Include(c => c.Contact)
            .Include(c => c.FiscalInformation)
            .FirstOrDefault();
        if (contractor == null)
        {
            throw new NullReferenceException();
        }
        return contractor;
    }
}