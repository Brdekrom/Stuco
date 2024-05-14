namespace Stuco.Domain.Entities;

public class Project : EntityBase
{
    public List<Stukadoor> Stukadoren { get; set; }
    public Klant Klant { get; set; }
}