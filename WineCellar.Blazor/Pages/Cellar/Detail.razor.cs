using System.Security.Claims;
using WineCellar.Application.Features.UserWines.DeleteUserWine;
using WineCellar.Application.Features.UserWines.GetUserWineDetail;
using WineCellar.Application.Features.UserWines.UpdateUserWine;
using WineCellar.Blazor.Components.Dialog;

namespace WineCellar.Blazor.Pages.Cellar;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }
    [Inject] private IDialogService _dialogService { get; set; }

    private UserWineDto _userWine { get; set; } = new();
    private string _userId { get; set; } = string.Empty;
    private string _userName { get; set; } = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userId = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
        _userName = authState.User.Identity.Name ?? string.Empty;

        if (Id is not 0)
        {
            _userWine = await _mediator.Send(new GetUserWineDetailRequest(Id, _userId));
        }
    }

    private async Task RemoveBottle()
    {
        if (_userWine.Amount > 1)
        {
            _userWine.Amount--;
            await UpdateAmount();
        }
        else
        {
            DialogParameters parameters = new();
            parameters.Add("ContentText", $"Do your really want to remove {_userWine.Wine.Name} from your cellar?");

            DialogOptions options = new() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            var dialog = _dialogService.Show<DeleteDialog>("Delete", parameters, options);

            var result = await dialog.Result;

            if (!result.Canceled)
            {
                bool deleteSucces = await _mediator.Send(new DeleteUserWineCommand(_userWine.Id));

                if (deleteSucces)
                {
                    _snackbar.Add($"{_userWine.Wine.Name} was removed from your cellar.", Severity.Warning);

                    NavigateBackToOvierview();
                }
                else
                {
                    _snackbar.Add($"Could not remove {_userWine.Wine.Name} from your cellar.", Severity.Error);
                }
            }
        }
    }

    private async Task AddBottle()
    {
        _userWine.Amount++;
        await UpdateAmount();
    }

    private async Task UpdateAmount()
    {
        await _mediator.Send(new UpdateUserWineCommand(_userWine, _userName));
    }

    private void NavigateBackToOvierview()
    {
        _navManager.NavigateTo("/Cellar");
    }
}