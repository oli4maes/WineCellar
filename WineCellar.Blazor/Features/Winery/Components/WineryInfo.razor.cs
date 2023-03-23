namespace WineCellar.Blazor.Features.Winery.Components;

public partial class WineryInfo : ComponentBase
{
    [Parameter] public WineryDto Winery { get; set; }
}