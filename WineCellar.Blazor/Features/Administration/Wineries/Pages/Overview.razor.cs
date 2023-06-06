using WineCellar.Application.Features.Wineries.DeleteWinery;
using WineCellar.Application.Features.Wineries.GetWineries;
using WineCellar.Application.Features.Wineries.SetWineryIsSpotlit;
using WineCellar.Blazor.Shared.Components.Dialogs;

namespace WineCellar.Blazor.Features.Administration.Wineries.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private IDialogService _dialogService { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }

    private IEnumerable<WineryDto> _wineries { get; set; } = Enumerable.Empty<WineryDto>();
    private string _userName { get; set; } = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();    
        _userName = authState.User.Identity?.Name ?? string.Empty;
        
        await GetWineries();
    }

    private void OpenWinery(WineryDto winery)
    {
        _navManager.NavigateTo($"/Administration/Wineries/{winery.Id}");
    }

    private void AddWinery()
    {
        _navManager.NavigateTo($"/Administration/Wineries/0");
    }

    private async Task DeleteWinery(WineryDto winery)
    {
        DialogParameters parameters = new() { { "ItemToDelete", winery.Name.ToLower() } };
        var dialog = await _dialogService.ShowAsync<DeleteDialog>("Delete", parameters);
        var result = await dialog.Result;

        if (!result.Canceled)
        {
            var response = await _mediator.Send(new DeleteWineryRequest(winery.Id));

            if (response.SuccessfulDelete)
            {
                _snackbar.Add($"Winery {winery.Name} deleted.", Severity.Warning);

                await GetWineries();
            }
            else
            {
                _snackbar.Add($"Could not delete winery {winery.Name}", Severity.Error);
            }
        }
    }

    private async Task ToggleIsSpotlit(WineryDto winery)
    {
        var response = await _mediator.Send(new SetWineryIsSpotlitRequest(winery.Id, _userName));

        if (!string.IsNullOrEmpty(response.ErrorMessage))
        {
            _snackbar.Add(response.ErrorMessage, Severity.Error);
        }

        await GetWineries();
    }

    private async Task GetWineries()
    {
        var response = await _mediator.Send(new GetWineriesRequest());
        _wineries = response.Wineries;
    }
}