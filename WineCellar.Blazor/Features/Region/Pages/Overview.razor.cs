using WineCellar.Application.Features.Regions.GetRegions;

namespace WineCellar.Blazor.Features.Region.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }

    private List<RegionDto> _regions { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        await GetSpotlitRegions();
    }

    private async void SearchRegions(string query)
    {
        if (!string.IsNullOrEmpty(query))
        {
            var response = await _mediator.Send(new GetRegionsRequest(query));
            _regions = response.Regions;

            StateHasChanged();
        }
    }

    private async Task GetSpotlitRegions()
    {
        var response = await _mediator.Send(new GetRegionsRequest(null, true));
        _regions = response.Regions;
    }

    private void NavigateToRegionDetail(int regionId)
    {
        _navigationManager.NavigateTo($"/Regions/{regionId}");
    }
}