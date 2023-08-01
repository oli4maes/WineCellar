using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.GetCellarOverview;

public sealed class GetCellarOverviewResponse
{
    public IEnumerable<CellarOverviewDto> Bottles { get; set; } = new List<CellarOverviewDto>();

    public class CellarOverviewDto
    {
        public int WineId { get; set; }
        public string WineName { get; set; } = string.Empty;
        public string WineryName { get; set; } = string.Empty;
        public string? RegionName { get; set; } = string.Empty;
        public WineType WineType { get; set; }
        public int Amount { get; set; }
    }
}