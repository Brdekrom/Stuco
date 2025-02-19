using System.ComponentModel.DataAnnotations;

namespace Stuco.Domain.Abstractions;

public abstract class BaseEntity
{
    [Required]
    public int Id { get; set; }
}