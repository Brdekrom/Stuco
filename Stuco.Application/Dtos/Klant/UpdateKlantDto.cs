using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Dtos.Klant;

public class UpdateKlantDto : DtoBase
{
    [Required]
    private int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; }
}