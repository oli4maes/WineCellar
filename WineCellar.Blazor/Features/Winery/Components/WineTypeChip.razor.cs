namespace WineCellar.Blazor.Features.Winery.Components;

public partial class WineTypeChip : ComponentBase
{
    [Parameter] public WineType WineType { get; set; }

    private string _wineTypeColor { get; set; } = String.Empty;
    private string _wineTypeTextColor { get; set; } = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        SetWineTypeColor();
    }

    private void SetWineTypeColor()
    {
        switch (WineType)
        {
            case WineType.Red:
                _wineTypeColor = Colors.Red.Darken4;
                _wineTypeTextColor = Colors.Grey.Lighten5;
                break;
            case WineType.Rosé:
                _wineTypeColor = Colors.Red.Lighten3;
                _wineTypeTextColor = Colors.Grey.Darken4;
                break;
            case WineType.White:
                _wineTypeColor = Colors.Yellow.Lighten4;
                _wineTypeTextColor = Colors.Grey.Darken4;
                break;
            case WineType.Sparkling:
                _wineTypeColor = Colors.Amber.Lighten4;
                _wineTypeTextColor = Colors.Grey.Darken4;
                break;
        }
    }
}