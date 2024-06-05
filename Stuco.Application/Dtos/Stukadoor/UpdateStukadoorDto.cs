using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Dtos.Stukadoor;

public class UpdateStukadoorDto : DtoBase
{
    [Required]
    private int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    public int ProjectId { get; set; }
}