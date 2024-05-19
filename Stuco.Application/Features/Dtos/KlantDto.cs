namespace Stuco.Application.Features.Dtos;

public class KlantDto : DtoBase
{
    public string Name { get; set; }
    public List<ProjectDto> Projecten { get; set; }
}