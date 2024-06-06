using Stuco.Application.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Dtos.Project;

public sealed class CreateProjectDto : DtoBase
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    public int KlantId { get; set; }
}