namespace Stuco.Domain.Entities;

public class Project : EntityBase
{
    public string Name { get; set; }
    public int KlantId { get; set; }

    // Navigation properties
    public List<Stukadoor> Stukadoren { get; set; } = new List<Stukadoor>();

    public Klant Klant { get; set; }
}