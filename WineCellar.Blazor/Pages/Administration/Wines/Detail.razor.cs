using WineCellar.Application.Grapes.Queries.GetGrapes;
using WineCellar.Application.Wineries.Queries.GetWineries;
using WineCellar.Application.Wines.Commands.CreateWine;
using WineCellar.Application.Wines.Commands.UpdateWine;
using WineCellar.Application.Wines.Queries.GetWineById;
using WineCellar.Application.Wines.Queries.GetWineByName;
using WineCellar.Domain.Enums;
using static MudBlazor.Colors;

namespace WineCellar.Blazor.Pages.Administration.Wines;

public partial class Detail : ComponentBase
{
    [Parameter]
    public int Id { get; set; }

    [Inject]
    MediatR.IMediator _mediator { get; set; }

    [Inject]
    private NavigationManager _navManager { get; set; }

    [Inject]
    private AuthenticationStateProvider _authenticationStateProvider { get; set; }

    [Inject]
    private ISnackbar _snackbar { get; set; }

    private WineDto _wine { get; set; } = new();
    private bool _editMode { get; set; } = false;
    private string _userName { get; set; } = string.Empty;
    private List<WineryDto> _wineries = new();

    protected override async Task OnInitializedAsync()
    {
        _wineries = await _mediator.Send(new GetWineriesQuery());

        if (Id != 0)
        {
            _wine = await _mediator.Send(new GetWineByIdQuery(Id));
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

    protected async void HandleValidSubmit()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userName = authState.User.Identity.Name ?? string.Empty; 

        if (Id == 0) // Insert
        {
            // Check if there is an entity with the same name
            var existingWine = await _mediator.Send(new GetWineByNameQuery(_wine.Name));
            if (existingWine != null)
            {
                _snackbar.Add($"The wine with name: {existingWine.Name} already exists.", Severity.Error);
                return;
            }

            _wine = await _mediator.Send(new CreateWineCommand(_wine.Name, _wine.WineType, _wine.WineryId, _wine.Grapes, _userName));

            Id = _wine.Id;

            if (_wine is not null)
            {
                _editMode = false;
                _snackbar.Add("Saved", Severity.Success);

                StateHasChanged();
            }
            else
            {
                _snackbar.Add("Could not save the wine.", Severity.Error);
            }
        }
        else // Update
        {
            await _mediator.Send(new UpdateWineCommand(_wine, _userName));

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
        // if text is null or empty, don't return values (drop-down will not open)
        if (string.IsNullOrEmpty(value))
            return new List<WineryDto>();

        return _wineries.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }
}