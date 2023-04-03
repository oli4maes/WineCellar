using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.GetCellarOverview;

public sealed class GetCellarOverviewResponse
{
    public IEnumerable<UserWineOverviewDto> UserWines { get; set; } = new List<UserWineOverviewDto>();

    public class UserWineOverviewDto
    {
        public int Id { get; set; }
        public int WineId { get; set; }
        public string WineName { get; set; } = String.Empty;
        public string WineryName { get; set; } = String.Empty;
        public string? RegionName { get; set; } = String.Empty;
        public WineType WineType { get; set; }
        public int Amount { get; set; }
    }
}