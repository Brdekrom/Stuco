using Stuco.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Domain.Entities;

public class Project : EntityBase
{
    [MaxLength(20)]
    public string Name { get; set; }

    public int KlantId { get; set; }

    // Navigation properties
    public List<Stukadoor> Stukadoren { get; set; } = new List<Stukadoor>();

    public Klant Klant { get; set; }
}