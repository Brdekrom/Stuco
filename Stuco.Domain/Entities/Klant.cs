namespace Stuco.Domain.Entities;

public class Klant : EntityBase
{
    public List<Project> Projecten { get; set; }
}