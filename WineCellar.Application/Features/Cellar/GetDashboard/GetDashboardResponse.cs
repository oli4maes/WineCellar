namespace WineCellar.Application.Features.Cellar.GetDashboard;

public sealed class GetDashboardResponse
{
    public int AmountOfBottlesInCellar { get; set; }
    public double[]? AmountOfBottlesPerWineTypeData { get; set; }
    public string[]? AmountOfBottlesPerWineTypeLabels { get; set; }
}