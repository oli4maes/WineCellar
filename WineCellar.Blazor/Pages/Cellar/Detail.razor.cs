using System.Security.Claims;
using WineCellar.Application.Features.UserWines.CreateUserWine;
using WineCellar.Application.Features.UserWines.GetUserWineById;
using WineCellar.Application.Features.UserWines.UpdateUserWine;
using WineCellar.Application.Features.Wines.GetWines;

namespace WineCellar.Blazor.Pages.Cellar;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private MediatR.IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private UserWineDto _userWine { get; set; } = new();
    private bool _editMode { get; set; }
    private string _userId { get; set; } = string.Empty;
    private string _userName { get; set; } = string.Empty;
    private List<WineDto> _wines = new();

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userId = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
        _userName = authState.User.Identity.Name ?? string.Empty;

        if (Id is not 0)
        {
            _userWine = await _mediator.Send(new GetUserWineByIdQuery(Id, _userId));
        }
        else
        {
            _wines = await _mediator.Send(new GetWinesQuery());
            _userWine = new();
            _editMode = true;
        }
    }

    private void SetEditMode()
    {
        _editMode = true;
    }

    private void Back()
    {
        _navManager.NavigateTo("/Administration/Grapes");
    }

    private async void HandleValidSubmit()
    {
        if (Id is 0)
        {
            // TODO: Check if the user already has this wine.

            _userWine = await _mediator.Send(new CreateUserWineCommand(_userWine, _userName, _userId));

            Id = _userWine.Id;

            if (_userWine is not null)
            {
                _editMode = false;
                _snackbar.Add("Saved", Severity.Success);

                StateHasChanged();
            }
            else
            {
                _snackbar.Add("Could not save the wine to your cellar.", Severity.Error);
            }
        }
        else
        {
            await _mediator.Send(new UpdateUserWineCommand(_userWine, _userName));

            _editMode = false;
            _snackbar.Add("Saved", Severity.Success);

            StateHasChanged();
        }
    }

    private async Task<IEnumerable<WineDto>> SearchWine(string value)
    {
        if (string.IsNullOrEmpty(value))
            return new List<WineDto>();

        return _wines.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }
}