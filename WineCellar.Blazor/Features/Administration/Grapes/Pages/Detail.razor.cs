using WineCellar.Application.Features.Grapes.CreateGrape;
using WineCellar.Application.Features.Grapes.GetGrapeById;
using WineCellar.Application.Features.Grapes.GetGrapeByName;
using WineCellar.Application.Features.Grapes.UpdateGrape;

namespace WineCellar.Blazor.Features.Administration.Grapes.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; } = default!;

    private GrapeDto _grape { get; set; } = new();
    private bool _editMode { get; set; } = false;
    private string _userName { get; set; } = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        if (Id is not 0)
        {
            var response = await _mediator.Send(new GetGrapeByIdRequest(Id));
            _grape = response.Grape ?? new GrapeDto();
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

    private async void HandleValidSubmit()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userName = authState.User.Identity?.Name ?? string.Empty;

        if (Id == 0)
        {
            var grapeByNameResponse = await _mediator.Send(new GetGrapeByNameRequest(_grape.Name));
            if (grapeByNameResponse.Grape != null)
            {
                _snackbar.Add($"The grape with name: {grapeByNameResponse.Grape.Name} already exists.", Severity.Error);
                return;
            }

            var response = await _mediator.Send(new CreateGrapeRequest(_grape.Name, _grape.Description, _userName));
            _grape = response.Grape;

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
        else
        {
            await _mediator.Send(new UpdateGrapeRequest(_grape.Id, _grape.Name, _grape.Description, _userName));

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