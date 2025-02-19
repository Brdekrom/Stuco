namespace Stuco.Domain.Entities;

public class ExecutedAssignment
{
    public required string Description { get; set; }
    public required DateTime Date { get; set; }
    public required decimal Amount { get; set; }
}