using System.ComponentModel.DataAnnotations;

namespace Stuco.Domain.Entities;

public class Klant : EntityBase
{
    [MaxLength(20)]
    public string Name { get; set; }

    public List<Project> Projecten { get; set; } = new List<Project>();
}