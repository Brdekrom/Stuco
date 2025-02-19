using Stuco.Domain.Abstractions;

namespace Stuco.Domain.Entities;

public class Contractor : BaseEntity
{
    public required string CompanyName { get; set; }
    public required Contact Contact { get; set; }
    public required FiscalInformation FiscalInformation { get; set; }
    public List<Invoice> Invoices { get; set; }
}