using System.Security.Claims;
using WineCellar.Application.Features.Cellar.AddBottleToCellar;
using WineCellar.Application.Features.Wines.GetWines;

namespace WineCellar.Blazor.Features.Wine.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private List<WineDto> _wines { get; set; } = new();
    private string _auth0Id { get; set; } = String.Empty;
    private string _userName { get; set; } = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _auth0Id = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;
        _userName = authState.User.Identity?.Name ?? string.Empty;

        await GetData();
    }

    private async void SearchWines(string query)
    {
        if (!string.IsNullOrEmpty(query))
        {
            var response = await _mediator.Send(new GetWinesRequest(query, _auth0Id));
            _wines = response.Wines;

            StateHasChanged();
        }
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
        var response = await _mediator.Send(new AddBottleToCellarRequest(wineId, BottleSize.Standard, _userName, _auth0Id));

        if (response.Bottle is not null)
        {
            _snackbar.Add($"Added {response.Bottle.Wine?.Name} to your cellar.", Severity.Success);
            await GetData();
            StateHasChanged();
        }
    }

    private async Task GetData()
    {
        var response = await _mediator.Send(new GetWinesRequest(null, _auth0Id, true));
        _wines = response.Wines.OrderBy(x => x.IsInUserCellar).ToList();
    }
}