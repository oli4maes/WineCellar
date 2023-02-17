using System.Security.Claims;
using WineCellar.Application.Features.UserWines.DeleteUserWine;
using WineCellar.Application.Features.UserWines.GetUserWinesOverview;
using WineCellar.Blazor.Components.Dialog;

namespace WineCellar.Blazor.Pages.Cellar;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private IDialogService _dialogService { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private IEnumerable<GetUserWinesOverviewResponse.UserWineOverviewDto> _userWines { get; set; }
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
        var response = await _mediator.Send(new GetUserWinesOverviewQuery(_userId));
        _userWines = response.UserWines;
    }

    private void OpenUserWine(GetUserWinesOverviewResponse.UserWineOverviewDto userWine)
    {
        _navManager.NavigateTo($"/Cellar/UserWine/{userWine.Id}");
    }

    private async Task DeleteUserWine(GetUserWinesOverviewResponse.UserWineOverviewDto userWine)
    {
        DialogParameters parameters = new();
        parameters.Add("ContentText", $"Do your really want to remove {userWine.WineName} from your cellar?");

        DialogOptions options = new() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

        var dialog = _dialogService.Show<DeleteDialog>("Delete", parameters, options);

        var result = await dialog.Result;

        if (!result.Canceled)
        {
            bool deleteSucces = await _mediator.Send(new DeleteUserWineCommand(userWine.Id));

            if (deleteSucces)
            {
                _snackbar.Add($"{userWine.WineName} was removed from your cellar.", Severity.Warning);

                await GetUserWines();
            }
            else
            {
                _snackbar.Add($"Could not remove {userWine.WineName} from your cellar.", Severity.Error);
            }
        }
    }

    // Quick filter - filter globally across multiple columns (Name) with the same input
    private Func<GetUserWinesOverviewResponse.UserWineOverviewDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.WineName.Contains(_searchString, StringComparison.OrdinalIgnoreCase) ||
            x.WineryName.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };
}