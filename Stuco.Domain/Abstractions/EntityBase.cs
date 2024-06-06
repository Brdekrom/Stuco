using System.ComponentModel.DataAnnotations;

namespace Stuco.Domain.Abstractions;

public abstract class EntityBase
{
    [Required]
    public int Id { get; set; }
}