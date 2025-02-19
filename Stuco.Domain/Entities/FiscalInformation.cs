using Stuco.Domain.Abstractions;

namespace Stuco.Domain.Entities;

public class FiscalInformation : BaseEntity
{
    public string? BankName { get; set; }
    public string? BankAccountNumber { get; set; }
    public string? KvkNumber { get; set; }
    public required string BtwNumber { get; set; }
    public bool IsVatShifted { get; set; }
    
}