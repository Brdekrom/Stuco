using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Dtos.Stukadoor;

public sealed class CreateStukadoorDto() : DtoBase
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }
};