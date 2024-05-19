namespace Stuco.Domain.Entities;

public class Project : EntityBase
{
    public string Name { get; set; }
    public List<Stukadoor> Stukadoren { get; set; }
    public Klant Klant { get; set; }
}