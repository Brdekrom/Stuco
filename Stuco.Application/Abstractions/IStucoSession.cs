using Stuco.Domain.Entities;

namespace Stuco.Application.Abstractions;

public interface IStucoSession
{
    public Contractor GetCurrentContractor();
}