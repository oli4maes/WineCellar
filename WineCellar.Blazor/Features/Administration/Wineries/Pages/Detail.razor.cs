using WineCellar.Application.Features.Countries.GetCountries;
using WineCellar.Application.Features.Wineries.CreateWinery;
using WineCellar.Application.Features.Wineries.GetWineryById;
using WineCellar.Application.Features.Wineries.GetWineryByName;
using WineCellar.Application.Features.Wineries.UpdateWinery;

namespace WineCellar.Blazor.Features.Administration.Wineries.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }

    [Inject] Mediator.IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private WineryDto _winery { get; set; } = new();
    private bool _editMode { get; set; } = false;
    private string _userName { get; set; } = string.Empty;
    private List<CountryDto> _countries = new();

    protected override async Task OnInitializedAsync()
    {
        var getCountriesResponse = await _mediator.Send(new GetCountriesRequest());
        _countries = getCountriesResponse.Countries;

        if (Id != 0)
        {
            var response = await _mediator.Send(new GetWineryByIdRequest(Id));
            _winery = response.Winery ?? new WineryDto();
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
            var getWineryByNameResponse = await _mediator.Send(new GetWineryByNameRequest(_winery.Name));
            if (getWineryByNameResponse.Winery != null)
            {
                _snackbar.Add($"The winery with name: {getWineryByNameResponse.Winery.Name} already exists.",
                    Severity.Error);
                return;
            }

            var response =
                await _mediator.Send(new CreateWineryRequest(_winery.Name, _winery.Description, _userName,
                    _winery.Country?.Id));
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
}