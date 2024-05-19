namespace Stuco.Domain.Entities;

public class Stukadoor : Personeel
{
    public string Name { get; set; }
    public Project Projecten { get; set; }
}