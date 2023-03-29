namespace WineCellar.Blazor.Features.Cellar.Components;

public partial class WineTypeStatistics : ComponentBase
{
    [Parameter] public Dictionary<WineType, double>? AmountOfBottlesPerWineType { get; set; }
}