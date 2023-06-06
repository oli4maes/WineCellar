using WineCellar.Application.Features.Regions.GetRegions;
using WineCellar.Application.Features.Regions.SetRegionsIsSpotlit;

namespace WineCellar.Blazor.Features.Administration.Regions.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }
    [Inject] private IDialogService _dialogService { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }

    private IEnumerable<RegionDto> _regions = Enumerable.Empty<RegionDto>();
    
    private string _userName { get; set; } = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        await GetRegions();
        
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();    
        _userName = authState.User.Identity?.Name ?? string.Empty;
    }

    private async Task GetRegions()
    {
        var getRegionsResponse = await _mediator.Send(new GetRegionsRequest(null));
        _regions = getRegionsResponse.Regions;
    }

    private async Task ToggleIsSpotlit(RegionDto region)
    {
        var response = await _mediator.Send(new SetRegionIsSpotlitRequest(region.Id, _userName));

        if (!string.IsNullOrEmpty(response.ErrorMessage))
        {
            _snackbar.Add(response.ErrorMessage, Severity.Error);
        }

        await GetRegions();
    }
}