namespace Stuco.Application.Features.Dtos;

public class ProjectDto : DtoBase
{
    public string Name { get; set; }
    public List<StukadoorDto> Stukadoren { get; set; }
    public int KlantId { get; set; }
}