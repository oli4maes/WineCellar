using WineCellar.Application.Features.Grapes.GetGrapes;
using WineCellar.Application.Features.Regions.GetRegionsByCountry;
using WineCellar.Application.Features.Wineries.GetWineries;
using WineCellar.Application.Features.Wineries.GetWineryById;
using WineCellar.Application.Features.Wines.AddGrapeToWine;
using WineCellar.Application.Features.Wines.CreateWine;
using WineCellar.Application.Features.Wines.GetWineById;
using WineCellar.Application.Features.Wines.RemoveGrapeFromWine;
using WineCellar.Application.Features.Wines.UpdateWine;

namespace WineCellar.Blazor.Features.Administration.Wines.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Parameter] public int WineryId { get; set; }

    [Inject] private IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private WineDto _wine { get; set; } = new();
    private WineryDto _winery { get; set; } = new();
    private bool _editMode { get; set; }
    private string _userName { get; set; } = string.Empty;

    private List<GrapeDto> _grapes { get; set; } = new();
    private List<RegionDto> _regions { get; set; } = new();
    private GrapeDto? _selectedGrape { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userName = authState.User.Identity?.Name ?? string.Empty;

        await GetInitialData();

        if (Id is not 0)
        {
            var response = await _mediator.Send(new GetWineByIdRequest(Id));
            _wine = response.Wine!;
        }
        else
        {
            _wine = new()
            {
                WineType = WineType.White,
                Grapes = new(),
                WineryId = WineryId
            };

            _editMode = true;
        }
    }

    private void SetEditMode()
    {
        _editMode = true;
    }

    private async void HandleValidSubmit()
    {
        if (Id is 0)
        {
            var response =
                await _mediator.Send(new CreateWineRequest(_wine.Name, _wine.WineType, _wine.WineryId, _userName,
                    _wine.Region?.Id));

            _wine = response.Wine ?? new WineDto();

            if (_wine.Id is not 0)
            {
                Id = _wine.Id;

                _editMode = false;
                _snackbar.Add("Saved", Severity.Success);

                StateHasChanged();
            }
            else
            {
                _snackbar.Add("Could not save the wine.", Severity.Error);
            }
        }
        else
        {
            await _mediator.Send(
                new UpdateWineRequest(
                    _wine.Id,
                    _wine.Name,
                    _wine.WineType,
                    _userName,
                    _wine.Region?.Id));

            _editMode = false;
            _snackbar.Add("Saved", Severity.Success);

            StateHasChanged();
        }
    }

    private void Back()
    {
        _navManager.NavigateTo($"/Administration/Wineries/{WineryId}");
    }

    private async Task<IEnumerable<GrapeDto>> SearchGrape(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new List<GrapeDto>();

        return _grapes.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    private async Task RemoveGrape(GrapeDto grape)
    {
        _wine.Grapes.Remove(grape);

        await _mediator.Send(new RemoveGrapeFromWineRequest(grape.Id, Id));
    }

    private async Task AddGrape()
    {
        if (_selectedGrape is not null)
        {
            _wine.Grapes.Add(_selectedGrape);

            await _mediator.Send(new AddGrapeToWineRequest(_selectedGrape.Id, Id));
        }
    }

    private async Task GetInitialData()
    {
        var getWineryResponse = await _mediator.Send(new GetWineryByIdRequest(WineryId));
        _winery = getWineryResponse.Winery;

        var getGrapesResponse = await _mediator.Send(new GetGrapesRequest());
        _grapes = getGrapesResponse.Grapes;

        var regionsResponse = await _mediator.Send(new GetRegionsByCountryRequest((int)_winery.CountryId!));
        _regions = regionsResponse.Regions;
    }
}