using System.Security.Claims;
using WineCellar.Application.Features.UserWines.DeleteUserWine;
using WineCellar.Application.Features.UserWines.GetUserWines;
using WineCellar.Blazor.Components.Dialog;

namespace WineCellar.Blazor.Pages.Cellar;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private IDialogService _dialogService { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private IEnumerable<UserWineDto> _userWines { get; set; }
    private string _userId { get; set; } = String.Empty;
    private string _searchString = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userId = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

        await GetUserWines();
    }

    private async Task GetUserWines()
    {
        _userWines = await _mediator.Send(new GetUserWinesQuery(_userId));
    }

    private void AddUserWine()
    {
    }

    private void OpenUserWine(UserWineDto userWine)
    {
        _navManager.NavigateTo($"/Cellar/UserWine/{userWine.Id}");
    }

    private async Task DeleteUserWine(UserWineDto userWine)
    {
        DialogParameters parameters = new();
        parameters.Add("ContentText", $"Do your really want to remove {userWine.Wine.Name} from your cellar?");

        DialogOptions options = new() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

        var dialog = _dialogService.Show<DeleteDialog>("Delete", parameters, options);

        var result = await dialog.Result;

        if (!result.Canceled)
        {
            bool deleteSucces = await _mediator.Send(new DeleteUserWineCommand(userWine.Id));

            if (deleteSucces)
            {
                _snackbar.Add($"{userWine.Wine.Name} was removed from your cellar.", Severity.Warning);

                await GetUserWines();
            }
            else
            {
                _snackbar.Add($"Could not remove {userWine.Wine.Name} from your cellar.", Severity.Error);
            }
        }
    }

    // Quick filter - filter globally across multiple columns (Name) with the same input
    private Func<UserWineDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.Wine.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };
}