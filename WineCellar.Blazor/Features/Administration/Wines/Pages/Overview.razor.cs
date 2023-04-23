using WineCellar.Application.Features.Wines.DeleteWine;
using WineCellar.Application.Features.Wines.GetWines;
using WineCellar.Application.Features.Wines.SetWineIsSpotlit;
using WineCellar.Blazor.Shared.Components.Dialogs;

namespace WineCellar.Blazor.Features.Administration.Wines.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private IDialogService _dialogService { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }

    private IEnumerable<WineDto> _wines = Enumerable.Empty<WineDto>();
    private string _searchString = String.Empty;
    private string _userName { get; set; } = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();    
        _userName = authState.User.Identity?.Name ?? string.Empty;
        
        await GetWines();
    }

    private Func<WineDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase) ||
            x.WineryName.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };

    private void OpenWine(WineDto wine)
    {
        _navManager.NavigateTo($"/Administration/Wines/{wine.Id}");
    }

    private void AddWine()
    {
        _navManager.NavigateTo($"/Administration/Wines/0");
    }

    private async Task DeleteWine(WineDto wine)
    {
        DialogParameters parameters = new() { { "ItemToDelete", wine.Name.ToLower() } };
        var dialog = await _dialogService.ShowAsync<DeleteDialog>("Delete", parameters);
        var result = await dialog.Result;

        if (!result.Canceled)
        {
            var response = await _mediator.Send(new DeleteWineRequest(wine.Id));

            if (response.SuccessfulDelete)
            {
                _snackbar.Add($"Wine {wine.Name} deleted.", Severity.Warning);

                await GetWines();
            }
            else
            {
                _snackbar.Add($"Could not delete wine {wine.Name}", Severity.Error);
            }
        }
    }

    private async Task GetWines()
    {
        var response = await _mediator.Send(new GetWinesRequest(null, null, false, true));
        _wines = response.Wines;
    }
    
    private async Task ToggleIsSpotlit(WineDto wine)
    {
        var response = await _mediator.Send(new SetWineIsSpotlitRequest(wine.Id, _userName));

        if (!string.IsNullOrEmpty(response.ErrorMessage))
        {
            _snackbar.Add(response.ErrorMessage, Severity.Error);
        }

        await GetWines();
    }
}