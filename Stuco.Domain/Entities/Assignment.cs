namespace Stuco.Domain.Entities;

public class Assignment
{
    public required Client Client { get; set; }
    public required List<ExecutedAssignment> ExecutedAssignment { get; set; }
}