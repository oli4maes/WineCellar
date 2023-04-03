using WineCellar.Application.Features.Wineries.GetWineryDetail;

namespace WineCellar.Blazor.Features.Winery.Components;

public partial class WineCard : ComponentBase
{
    [Parameter] public WineDto Wine { get; set; }
    [Parameter] public bool ShowWinery { get; set; }
    [Parameter] public EventCallback<int> OnNavigateToWineDetail { get; set; }
    [Parameter] public EventCallback OnNavigateToCellar { get; set; }
    [Parameter] public EventCallback<int> OnAddToCellar { get; set; }
    

    private async void NavigateToWineDetail()
    {
        await OnNavigateToWineDetail.InvokeAsync(Wine.Id);
    }

    private async void AddToCellar()
    {
        await OnAddToCellar.InvokeAsync(Wine.Id);
    }

    private async void NavigateToCellar()
    {
        await OnNavigateToCellar.InvokeAsync();
    }
}