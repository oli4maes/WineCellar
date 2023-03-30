using WineCellar.Domain.Enums;

namespace WineCellar.Application.Dtos;

public class WineDto
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;

    public int WineryId { get; set; }
    public string WineryName { get; set; } = String.Empty;
    public WineryDto Winery { get; set; } = new();

    public WineType WineType { get; set; }

    public List<GrapeDto> Grapes { get; set; } = new();

    public int? CountryId { get; set; }
    public string? CountryName { get; set; }
    public CountryDto? Country { get; set; }
}