using Stuco.Domain.Abstractions;

namespace Stuco.Domain.Entities;

public class Contact : BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public string PhoneNumber { get; set; }
}