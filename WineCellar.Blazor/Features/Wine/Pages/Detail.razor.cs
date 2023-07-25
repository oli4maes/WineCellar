using System.Security.Claims;
using WineCellar.Application.Features.Cellar.AddBottleToCellar;
using WineCellar.Application.Features.Cellar.GetBottlesByWineId;
using WineCellar.Application.Features.Wines.GetWineById;
using WineCellar.Blazor.Features.Wine.Components;

namespace WineCellar.Blazor.Features.Wine.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }
    [Inject] private IDialogService _dialogService { get; set; }

    private WineDto _wine;
    private List<GetBottlesByWineIdResponse.BottleDto> _bottles { get; set; } = new();
    private string _userName { get; set; } = string.Empty;
    private string _auth0Id { get; set; } = string.Empty;

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

        await GetBottles();
    }

    private async Task GetBottles()
    {
        GetBottlesByWineIdResponse response = await _mediator.Send(new GetBottlesByWineIdRequest(_auth0Id, _wine.Id));
        _bottles = response.Bottles;
    }

    private async Task AddBottleToCellar()
    {
        var dialog = await _dialogService.ShowAsync<AddBottleToCellarDialog>();
        var result = await dialog.Result;
        AddBottleToCellarDialog.Bottle bottle = (AddBottleToCellarDialog.Bottle)result.Data;
        
        if (!result.Canceled)
        {
            var response = await _mediator.Send(
                new AddBottleToCellarRequest(_wine.Id, bottle.Size, _userName, _auth0Id, bottle.Vintage)
            );

            if (response.Bottle is not null)
            {
                await GetBottles();
                _snackbar.Add($"Added bottle to your cellar.", Severity.Success);
            }
        }
    }

    private async Task SetBottleStatus(GetBottlesByWineIdResponse.BottleDto bottle)
    {
    }

    private void NavigateToWinery()
    {
        _navigationManager.NavigateTo($"/Wineries/{_wine.Winery.Id}");
    }
}