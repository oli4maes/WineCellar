using WineCellar.Domain.Enums;

namespace WineCellar.Application.Dtos;

public class WineDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public int WineryId { get; set; }
    public string WineryName { get; set; } = String.Empty;
    public WineType WineType { get; set; }
    public WineryDto Winery { get; set; } = new();
    public List<GrapeDto> Grapes { get; set; } = new();
}