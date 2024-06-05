using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Dtos.Project;

public class UpdateProjectDto : DtoBase
{
    [Required]
    private int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    public int KlantId { get; set; }
}