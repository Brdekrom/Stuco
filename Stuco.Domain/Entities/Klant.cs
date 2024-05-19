namespace Stuco.Domain.Entities;

public class Klant : EntityBase
{
    public string Name { get; set; }
    public List<Project> Projecten { get; set; }
}