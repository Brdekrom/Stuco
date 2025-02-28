using Microsoft.EntityFrameworkCore;
using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Application.Services;

internal class StucoStucoSession(IRepository repository) : IStucoSession
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