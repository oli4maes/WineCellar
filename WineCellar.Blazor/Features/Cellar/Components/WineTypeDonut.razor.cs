namespace WineCellar.Blazor.Features.Cellar.Components;

public partial class WineTypeDonut : ComponentBase
{
    [Parameter] public double[]? AmountOfBottlesPerWineTypeData { get; set; }
    [Parameter] public string[]? AmountOfBottlesPerWineTypeLabels { get; set; }
    [Parameter] public int AmountOfBottlesInCellar { get; set; }

    private int _index = -1;
    private ChartOptions _chartOptions { get; set; }
    private double[] _amountOfBottlesPerWineType { get; set; }

    protected override async Task OnInitializedAsync()
    {
        _chartOptions = new ChartOptions()
        {
            ChartPalette = new[]
                { Colors.Yellow.Lighten1, Colors.Red.Lighten3, Colors.Red.Darken4, Colors.Amber.Lighten1 }
        };
    }
}