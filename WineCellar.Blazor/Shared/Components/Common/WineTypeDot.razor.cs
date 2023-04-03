namespace WineCellar.Blazor.Shared.Components.Common;

public partial class WineTypeDot : ComponentBase
{
    [Parameter] public WineType WineType { get; set; }
    private string _wineTypeColor { get; set; } = String.Empty;

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
                break;
            case WineType.Rosé:
                _wineTypeColor = Colors.Red.Lighten3;
                break;
            case WineType.White:
                _wineTypeColor = Colors.Yellow.Lighten4;
                break;
            case WineType.Sparkling:
                _wineTypeColor = Colors.Amber.Lighten4;
                break;
        }
    }
}