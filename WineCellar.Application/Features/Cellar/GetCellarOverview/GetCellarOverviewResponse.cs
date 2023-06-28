using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.GetCellarOverview;

public sealed class GetCellarOverviewResponse
{
    public IEnumerable<CellarOverviewDto> Bottles { get; set; } = new List<CellarOverviewDto>();

    public class CellarOverviewDto
    {
        public int Id { get; set; }
        public int WineId { get; set; }
        public string WineName { get; set; } = String.Empty;
        public string WineryName { get; set; } = String.Empty;
        public string? RegionName { get; set; } = String.Empty;
        public WineType WineType { get; set; }
        public BottleSize BottleSize { get; set; }
        public int? Vintage { get; set; }
    }
}