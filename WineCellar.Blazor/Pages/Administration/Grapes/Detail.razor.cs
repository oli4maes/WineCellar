using WineCellar.Application.Dtos;
using WineCellar.Application.Features.Grapes.CreateGrape;
using WineCellar.Application.Features.Grapes.GetGrapeById;
using WineCellar.Application.Features.Grapes.GetGrapeByName;
using WineCellar.Application.Features.Grapes.UpdateGrape;

namespace WineCellar.Blazor.Pages.Administration.Grapes;

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

    private GrapeDto _grape { get; set; } = new();
    private bool _editMode { get; set; } = false;
    private string _userName { get; set; } = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            _grape = await _mediator.Send(new GetGrapeByIdQuery(Id));
        }
        else
        {
            _grape = new();
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
            var existingGrape = await _mediator.Send(new GetGrapeByNameQuery(_grape.Name));
            if (existingGrape != null)
            {
                _snackbar.Add($"The grape with name: {existingGrape.Name} already exists.", Severity.Error);
                return;
            }           

            _grape = await _mediator.Send(new CreateGrapeCommand(_grape, _userName));

            Id = _grape.Id;

            if (_grape is not null)
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
            await _mediator.Send(new UpdateGrapeCommand(_grape, _userName));

            _editMode = false;
            _snackbar.Add("Saved", Severity.Success);

            StateHasChanged();
        }
    }

    private void Back()
    {
        _navManager.NavigateTo("/Administration/Grapes");
    }
}