using System.Security.Claims;
using WineCellar.Application.Features.UserWines.GetUserWines;

namespace WineCellar.Blazor.Pages.Cellar;

public partial class Overview : ComponentBase
{
    [Inject]
    private Mediator.IMediator _mediator { get; set; }

    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }

    private IEnumerable<UserWineDto> _userWines { get; set; }
    private string _userId { get; set; } = string.Empty;
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
    }

    private void DeleteUserWine(UserWineDto userWine)
    {
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