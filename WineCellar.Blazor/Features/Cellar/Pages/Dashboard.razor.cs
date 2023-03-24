using System.Security.Claims;
using WineCellar.Application.Features.Cellar.GetDashboard;

namespace WineCellar.Blazor.Features.Cellar.Pages;

public partial class Dashboard : ComponentBase
{
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private IMediator _mediator { get; set; }

    private string _userId { get; set; } = String.Empty;

    private GetDashboardResponse _dashboardResponse { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userId = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;

        _dashboardResponse = await _mediator.Send(new GetDashboardRequest(_userId));
    }
}