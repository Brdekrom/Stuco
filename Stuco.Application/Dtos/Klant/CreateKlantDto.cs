using Stuco.Application.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Dtos.Klant;

public sealed class CreateKlantDto : DtoBase
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }
}