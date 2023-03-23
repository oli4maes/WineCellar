using WineCellar.Application.Features.Grapes.GetGrapes;
using WineCellar.Application.Features.Wineries.GetWineries;
using WineCellar.Application.Features.Wines.AddGrapeToWine;
using WineCellar.Application.Features.Wines.CreateWine;
using WineCellar.Application.Features.Wines.GetWineById;
using WineCellar.Application.Features.Wines.GetWineByName;
using WineCellar.Application.Features.Wines.RemoveGrapeFromWine;
using WineCellar.Application.Features.Wines.UpdateWine;

namespace WineCellar.Blazor.Features.Administration.Wines.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }

    [Inject] private IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private WineDto _wine { get; set; } = new();
    private bool _editMode { get; set; }
    private string _userName { get; set; } = string.Empty;
    private List<WineryDto> _wineries = new();
    private List<GrapeDto> _grapes = new();
    private GrapeDto? _selectedGrape { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var getWineriesResponse = await _mediator.Send(new GetWineriesRequest());
        _wineries = getWineriesResponse.Wineries.ToList();

        var getGrapesResponse = await _mediator.Send(new GetGrapesRequest());
        _grapes = getGrapesResponse.Grapes;

        if (Id is not 0)
        {
            var response = await _mediator.Send(new GetWineByIdRequest(Id));
            _wine = response.Wine ?? new WineDto();
        }
        else
        {
            _wine = new();
            _wine.WineType = WineType.White;
            _wine.Grapes = new();
            _editMode = true;
        }
    }

    private void SetEditMode()
    {
        _editMode = true;
    }

    private async void HandleValidSubmit()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userName = authState.User.Identity?.Name ?? string.Empty;

        _wine.WineryId = _wine.Winery.Id;

        if (Id is 0)
        {
            var getWineByNameResponse = await _mediator.Send(new GetWineByNameRequest(_wine.Name));
            if (getWineByNameResponse.Wine != null)
            {
                _snackbar.Add($"The wine with name: {getWineByNameResponse.Wine.Name} already exists.", Severity.Error);
                return;
            }

            var response =
                await _mediator.Send(new CreateWineRequest(_wine.Name, _wine.WineType, _wine.WineryId, _userName));
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
                new UpdateWineRequest(_wine.Id, _wine.Name, _wine.WineType, _wine.WineryId, _userName));

            _editMode = false;
            _snackbar.Add("Saved", Severity.Success);

            StateHasChanged();
        }
    }

    private void Back()
    {
        _navManager.NavigateTo("/Administration/Wines");
    }

    private async Task<IEnumerable<WineryDto>> SearchWinery(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new List<WineryDto>();

        return _wineries.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
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
}