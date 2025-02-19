using Stuco.Domain.Abstractions;

namespace Stuco.Domain.Entities;

public class Address : BaseEntity
{
    public required string Street { get; set; }
    public required string PostalCode { get; set; }
    public required string City { get; set; }
}