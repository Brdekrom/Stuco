using Stuco.Application.Abstractions;

namespace Stuco.Application.Dtos.Project;

public sealed class ViewProjectDto : DtoBase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int KlantId { get; set; }
    public List<int> Stukadoren { get; set; }
}