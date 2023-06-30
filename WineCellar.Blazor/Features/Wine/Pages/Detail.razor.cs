using System.Security.Claims;
using WineCellar.Application.Features.Cellar.AddBottleToCellar;
using WineCellar.Application.Features.Cellar.GetBottlesByWineId;
using WineCellar.Application.Features.Wines.GetWineById;

namespace WineCellar.Blazor.Features.Wine.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }

    private WineDto _wine;
    private BottleDto _bottle { get; set; } = new();
    private string _userName { get; set; } = string.Empty;
    private string _auth0Id { get; set; } = string.Empty;
    private bool _isWineInUserCellar { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userName = authState.User.Identity?.Name ?? string.Empty;
        _auth0Id = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;
    }

    protected override async Task OnParametersSetAsync()
    {
        var getWineByIdResponse = await _mediator.Send(new GetWineByIdRequest(Id));
        _wine = getWineByIdResponse.Wine ?? new();

        await GetUserWine();
    }

    private async Task GetUserWine()
    {
        GetBottlesByWineIdResponse response = await _mediator.Send(new GetBottlesByWineIdRequest(_auth0Id, _wine.Id));
    }

    private async Task AddWineToCellar()
    {
        var response =
            await _mediator.Send(new AddBottleToCellarRequest(_wine.Id, BottleSize.Standard, _userName, _auth0Id));

        if (response.Bottle is not null)
        {
            await GetUserWine();
            _isWineInUserCellar = true;
            _snackbar.Add($"Added {_wine.Name} to your cellar.", Severity.Success);
        }
    }

    private void NavigateToWinery()
    {
        _navigationManager.NavigateTo($"/Wineries/{_wine.Winery.Id}");
    }
}