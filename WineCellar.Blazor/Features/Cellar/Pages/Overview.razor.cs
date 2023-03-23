using System.Security.Claims;
using WineCellar.Application.Features.Cellar.GetCellarOverview;
using WineCellar.Application.Features.Cellar.RemoveWineFromCellar;
using WineCellar.Blazor.Shared.Components.Dialogs;

namespace WineCellar.Blazor.Features.Cellar.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private IDialogService _dialogService { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

    private IEnumerable<GetCellarOverviewResponse.UserWineOverviewDto> _userWines { get; set; }
    private string _userId { get; set; } = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userId = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

        await GetUserWines();
    }

    private async Task GetUserWines()
    {
        var response = await _mediator.Send(new GetCellarOverviewRequest(_userId));
        _userWines = response.UserWines;
    }

    private void OpenWine(GetCellarOverviewResponse.UserWineOverviewDto userWine)
    {
        _navManager.NavigateTo($"/Wines/{userWine.WineId}");
    }

    private async Task DeleteUserWine(GetCellarOverviewResponse.UserWineOverviewDto userWine)
    {
        DialogParameters parameters = new()
            { { "Text", $"Do your really want to remove {userWine.WineName.ToLower()} from your cellar?" } };
        var dialog = _dialogService.Show<DeleteDialog>("Delete", parameters);
        var result = await dialog.Result;

        if (!result.Canceled)
        {
            var response = await _mediator.Send(new RemoveWineFromCellarRequest(userWine.Id));

            if (response.SuccessfulDelete)
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
}