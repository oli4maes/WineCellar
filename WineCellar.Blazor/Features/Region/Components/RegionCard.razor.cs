namespace WineCellar.Blazor.Features.Region.Components;

public partial class RegionCard : ComponentBase
{
    [Parameter] public RegionDto Region { get; set; }
    [Parameter] public EventCallback<int> OnNavigateToRegionDetail { get; set; }

    private async void NavigateToRegionDetail()
    {
        await OnNavigateToRegionDetail.InvokeAsync(Region.Id);
    }
}