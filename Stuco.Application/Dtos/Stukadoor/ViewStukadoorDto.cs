using Stuco.Application.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Dtos.Stukadoor;

public sealed class ViewStukadoorDto : DtoBase
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    public int ProjectId { get; set; }
}