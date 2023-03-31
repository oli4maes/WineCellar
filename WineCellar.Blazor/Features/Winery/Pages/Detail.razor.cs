using System.Security.Claims;
using WineCellar.Application.Features.Cellar.AddWineToCellar;
using WineCellar.Application.Features.Wineries.GetWineryDetail;

namespace WineCellar.Blazor.Features.Winery.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private string _auth0Id { get; set; } = String.Empty;
    private string _userName { get; set; } = String.Empty;
    private WineryDto _winery { get; set; }

    private IEnumerable<GetWineryDetailResponse.WineDto> _wines { get; set; } =
        new List<GetWineryDetailResponse.WineDto>();

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _auth0Id = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;
        _userName = authState.User.Identity?.Name ?? string.Empty;

        await GetData();
        
    }

    private void NavigateToWineDetail(int wineId)
    {
        _navigationManager.NavigateTo($"/Wines/{wineId}");
    }

    private void NavigateToCellar()
    {
        _navigationManager.NavigateTo("/Cellar");
    }

    private async Task AddWineToCellar(int wineId)
    {
        var response = await _mediator.Send(new AddWineToCellarRequest(wineId, 1, _userName, _auth0Id));

        if (response.UserWine is not null)
        {
            _snackbar.Add($"Added {response.UserWine.Wine?.Name} to your cellar.", Severity.Success);
            await GetData();
            StateHasChanged();
        }
    }

    private async Task GetData()
    {
        var getWineryByIdResponse = await _mediator.Send(new GetWineryDetailRequest(Id, _auth0Id));
        _winery = getWineryByIdResponse.Winery ?? new WineryDto();
        _wines = getWineryByIdResponse.Wines.OrderByDescending(x => x.IsInUserCellar);
    }
}