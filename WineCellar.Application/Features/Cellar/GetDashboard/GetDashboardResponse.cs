using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.GetDashboard;

public sealed class GetDashboardResponse
{
    public int AmountOfBottlesInCellar { get; set; }
    public double[]? AmountOfBottlesPerWineTypeData { get; set; }
    public string[]? AmountOfBottlesPerWineTypeLabels { get; set; }
    public WineType FavouriteWineType { get; set; }
    public Dictionary<WineType, double>? AmountOfBottlesPerWineType { get; set; }
    public string FavouriteWine { get; set; } = String.Empty;
    public int? FavouriteWineId { get; set; }
    public string FavouriteWinery { get; set; } = String.Empty;
    public int? FavouriteWineryId { get; set; }
}