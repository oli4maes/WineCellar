using System.Security.Claims;
using WineCellar.Application.Features.Cellar.AddWineToCellar;
using WineCellar.Application.Features.Cellar.GetUserWineByWineId;
using WineCellar.Application.Features.Cellar.RemoveWineFromCellar;
using WineCellar.Application.Features.Cellar.UpdateUserWine;
using WineCellar.Application.Features.Wines.GetWineById;
using WineCellar.Blazor.Shared.Components.Dialogs;

namespace WineCellar.Blazor.Features.Wine.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }
    [Inject] private IDialogService _dialogService { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }

    private WineDto _wine;
    private UserWineDto _userWine { get; set; } = new();
    private string _userName { get; set; } = string.Empty;
    private string _auth0Id { get; set; } = string.Empty;
    private bool _isWineInUserWines { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userName = authState.User.Identity?.Name ?? string.Empty;
        _auth0Id = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;

        var getWineByIdResponse = await _mediator.Send(new GetWineByIdRequest(Id));
        _wine = getWineByIdResponse.Wine ?? new();

        await GetUserWine();
    }

    private async Task GetUserWine()
    {
        GetUserWineByWineIdResponse response = await _mediator.Send(new GetUserWineByWineIdRequest(_auth0Id, _wine.Id));

        if (response?.UserWine is not null)
        {
            _userWine = response.UserWine;
            _isWineInUserWines = true;
        }
    }

    private async Task AddWineToCellar()
    {
        var response = await _mediator.Send(new AddWineToCellarRequest(_wine.Id, 1, _userName, _auth0Id));

        if (response.UserWine is not null)
        {
            await GetUserWine();
            _isWineInUserWines = true;
            _snackbar.Add($"Added {_wine.Name} to your cellar.", Severity.Success);
        }
    }

    private async Task RemoveBottle()
    {
        if (_userWine.Amount > 1)
        {
            _userWine.Amount--;
            await UpdateAmount();
        }
        else
        {
            DialogParameters parameters = new();
            parameters.Add("ItemToDelete", _wine.Name.ToLower());

            var dialog = _dialogService.Show<DeleteDialog>("Delete", parameters);

            var result = await dialog.Result;

            if (!result.Canceled)
            {
                var response = await _mediator.Send(new RemoveWineFromCellarRequest(_userWine.Id));

                if (response.SuccessfulDelete)
                {
                    _isWineInUserWines = false;
                    _snackbar.Add($"{_wine.Name} was removed from your cellar.", Severity.Warning);
                }
                else
                {
                    _snackbar.Add($"Could not remove {_wine.Name} from your cellar.", Severity.Error);
                }
            }
        }
    }

    private async Task AddBottle()
    {
        _userWine.Amount++;
        await UpdateAmount();
    }

    private async Task UpdateAmount()
    {
        await _mediator.Send(new UpdateUserWineRequest(_userWine.Id, _userWine.Amount, _userName, _auth0Id));
    }

    private void NavigateToWinery()
    {
        _navigationManager.NavigateTo($"/Wineries/{_wine.Winery.Id}");
    }
}