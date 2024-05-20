using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Features.Dtos.Create;

public class CreateProjectDto
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }
}