using WineCellar.Application.Dtos;
using WineCellar.Application.Features.Wineries.CreateWinery;
using WineCellar.Application.Features.Wineries.GetWineryById;
using WineCellar.Application.Features.Wineries.GetWineryByName;
using WineCellar.Application.Features.Wineries.UpdateWinery;

namespace WineCellar.Blazor.Pages.Administration.Wineries;

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

    private WineryDto _winery { get; set; } = new();
    private bool _editMode { get; set; } = false;
    private string _userName { get; set; } = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            _winery = await _mediator.Send(new GetWineryByIdQuery(Id));
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
        _userName = authState.User.Identity.Name ?? string.Empty;

        if (Id == 0) // Insert
        {
            // Check if there is an entity with the same name
            var existingWinery = await _mediator.Send(new GetWineryByNameQuery(_winery.Name));
            if (existingWinery != null)
            {
                _snackbar.Add($"The winery with name: {existingWinery.Name} already exists.", Severity.Error);
                return;
            }

            _winery = await _mediator.Send(new CreateWineryCommand(_winery, _userName));

            Id = _winery.Id;

            if (_winery is not null)
            {
                _editMode = false;
                _snackbar.Add("Saved", Severity.Success);

                StateHasChanged();
            }
            else
            {
                _snackbar.Add("Could not save the grape.", Severity.Error);
            }
        }
        else // Update
        {
            await _mediator.Send(new UpdateWineryCommand(_winery, _userName));

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