using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Features.Dtos;

public class CreateKlantDto
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }
}