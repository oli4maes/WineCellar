using System.Security.Claims;
using WineCellar.Application.Features.UserWines.GetUserWineDetail;

namespace WineCellar.Blazor.Pages.Cellar;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private NavigationManager _navManager { get; set; }
    [Inject] private ISnackbar _snackbar { get; set; }

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

    private async Task ChangeAmount()
    {
        
    }

    private void Back()
    {
        _navManager.NavigateTo("/Cellar");
    }
}