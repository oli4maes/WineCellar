namespace WineCellar.Blazor.Features.Wine.Components;

public partial class WineInfo : ComponentBase
{
    [Parameter] public WineDto Wine { get; set; } = new();
    [Parameter] public EventCallback OnNavigateToWinery { get; set; }

    private async Task NavigateToWinery()
    {
        await OnNavigateToWinery.InvokeAsync();
    }
}