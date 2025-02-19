
using Stuco.Domain.Abstractions;

namespace Stuco.Domain.Entities;

public class Invoice : BaseEntity
{
    public long InvoiceNumber { get; private set; }
    public DateTime IssueDate { get; set; }
    public Contractor Contractor { get; private set; }
    public Client Client { get; private set; }
    public List<ExecutedAssignment> ExecutedAssignments { get; private set; } = new List<ExecutedAssignment>();
}