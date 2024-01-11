using System.Security.Claims;
using WineCellar.Application.Features.Cellar.GetDashboard;

namespace WineCellar.Blazor.Features.Cellar.Pages;

public partial class Dashboard : ComponentBase
{
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }

    private string _userId { get; set; } = string.Empty;
    private int _index = -1;
    private string[] _xAxisLabels { get; set; } = [];
    private List<ChartSeries> _series = [];

    private ChartOptions _chartOptions = new()
    {
        InterpolationOption = InterpolationOption.NaturalSpline
    };

    private GetDashboardResponse _dashboardResponse { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _userId = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;

        _dashboardResponse = await _mediator.Send(new GetDashboardRequest(_userId));

        _xAxisLabels = _dashboardResponse.WinesInCellarLineChart.XAxisLabels.ToArray();
        _series = new List<ChartSeries>
        {
            new()
            {
                Name = _dashboardResponse.WinesInCellarLineChart.Name,
                Data = _dashboardResponse.WinesInCellarLineChart.Values.ToArray()
            }
        };

        _chartOptions.YAxisTicks = 10;
    }

    private void NavigateToWineryDetail(int id)
    {
        _navigationManager.NavigateTo($"Wineries/{id}");
    }

    private void NavigateToWineDetail(int id)
    {
        _navigationManager.NavigateTo($"Wines/{id}");
    }
}