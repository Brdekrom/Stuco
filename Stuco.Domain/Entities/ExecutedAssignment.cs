using Stuco.Domain.Abstractions;

namespace Stuco.Domain.Entities;

public class ExecutedAssignment : BaseEntity
{
    public required string Description { get; set; }
    public required DateTime Date { get; set; }
    public required decimal Amount { get; set; }
}