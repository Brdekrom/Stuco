namespace Stuco.Application.Features.Dtos;

public class ProjectDto : DtoBase
{
    public List<StukadoorDto> Stukadoren { get; set; }
    public int KlantId { get; set; }
}