using Stuco.Application.Abstractions;

namespace Stuco.Application.Dtos.Klant;

public sealed class ViewKlantDto : DtoBase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<int> Projecten { get; set; }
}