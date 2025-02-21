using Stuco.Domain.Abstractions;

namespace Stuco.Domain.Entities;

public class Assignment : BaseEntity
{
    public required Client Client { get; set; }
    public required List<ExecutedAssignment> ExecutedAssignment { get; set; }
}