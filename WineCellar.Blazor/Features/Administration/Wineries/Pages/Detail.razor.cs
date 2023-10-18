using WineCellar.Application.Features.Countries.GetCountries;
using WineCellar.Application.Features.Wineries.CreateWinery;
using WineCellar.Application.Features.Wineries.GetWineryById;
using WineCellar.Application.Features.Wineries.GetWineryByName;
using WineCellar.Application.Features.Wineries.UpdateWinery;
using WineCellar.Application.Features.Wines.DeleteWine;
using WineCellar.Application.Features.Wines.GetWines;
using WineCellar.Blazor.Shared.Components.Dialogs;

namespace WineCellar.Blazor.Features.Administration.Wineries.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }

    [Inject] private IDialogService _dialogService { get; set; }
    [Inject] IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private WineryDto _winery { get; set; } = new();
    private bool _editMode { get; set; } = false;
    private string _userName { get; set; } = string.Empty;
    private List<CountryDto> _countries = new();
    private IEnumerable<WineDto> _wines = Enumerable.Empty<WineDto>();

    protected override async Task OnInitializedAsync()
    {
        var getCountriesResponse = await _mediator.Send(new GetCountriesRequest());
        _countries = getCountriesResponse.Countries;

        if (Id != 0)
        {
            var response = await _mediator.Send(new GetWineryByIdRequest(Id));
            _winery = response.Winery!;

            await GetWines();
        }
        else
        {
            _winery = new();
            _editMode = true;
        }
    }

    private void SetEditMode()
    {
        _editMode = true;
    }

    protected async void HandleValidSubmit()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userName = authState.User.Identity?.Name ?? string.Empty;

        if (Id == 0)
        {
            var response =
                await _mediator.Send(new CreateWineryRequest(_winery.Name, _winery.Description, _userName,
                    _winery.Country?.Id));

            if (!string.IsNullOrEmpty(response.ErrorMessage))
            {
                _snackbar.Add(response.ErrorMessage, Severity.Error);
                return;
            }

            _winery = response.Winery;

            if (_winery.Id is not 0)
            {
                Id = _winery.Id;

                _editMode = false;
                _snackbar.Add("Saved", Severity.Success);

                StateHasChanged();
            }
            else
            {
                _snackbar.Add("Could not save the grape.", Severity.Error);
            }
        }
        else
        {
            await _mediator.Send(new UpdateWineryRequest(_winery.Id, _winery.Name, _winery.Description, _userName,
                _winery.Country?.Id));

            _editMode = false;
            _snackbar.Add("Saved", Severity.Success);

            StateHasChanged();
        }
    }

    private void Back()
    {
        _navManager.NavigateTo("/Administration/Wineries");
    }

    private void OpenWine(WineDto wine)
    {
        _navManager.NavigateTo($"/Administration/Wines/{Id}/{wine.Id}");
    }

    private void AddWine()
    {
        _navManager.NavigateTo($"/Administration/Wines/{Id}/0");
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
        var response = await _mediator.Send(new GetWinesRequest(null, null, _winery.Id, true));
        _wines = response.Wines;
    }
}