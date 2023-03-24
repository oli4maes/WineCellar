namespace WineCellar.Blazor.Features.Winery.Components;

public partial class WineryCard : ComponentBase
{
    [Parameter] public WineryDto Winery { get; set; }
    [Parameter] public EventCallback<int> OnNavigateToWineryDetail { get; set; }

    private async void NavigateToWineryDetail()
    {
        await OnNavigateToWineryDetail.InvokeAsync(Winery.Id);
    }
}