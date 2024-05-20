using System.ComponentModel.DataAnnotations;

namespace Stuco.Domain.Entities;

public class EntityBase
{
    [Required]
    public int Id { get; set; }
}