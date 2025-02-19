using Stuco.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Domain.Entities;

public class Client : BaseEntity
{
    public string CompanyName { get; set; }
    public Contact Contact { get; set; }
    public Address Address { get; set; }
    public FiscalInformation FiscalInformation { get; set; }
    public List<Invoice> Invoices { get; set; }
}