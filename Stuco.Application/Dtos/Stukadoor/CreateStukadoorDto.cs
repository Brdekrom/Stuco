using Stuco.Application.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Dtos.Stukadoor;

public sealed class CreateStukadoorDto() : DtoBase
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    public int ProjectId { get; set; }
};