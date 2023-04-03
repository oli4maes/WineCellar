using WineCellar.Application.Features.Wineries.GetWineries;
using WineCellar.Application.Features.Wineries.QueryWineries;

namespace WineCellar.Blazor.Features.Winery.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }

    private List<WineryDto> _wineries { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        var response = await _mediator.Send(new GetWineriesRequest(true));
        _wineries = response.Wineries;
    }

    private async void SearchWineries(string query)
    {
        if (!string.IsNullOrEmpty(query))
        {
            var response = await _mediator.Send(new QueryWineriesRequest(query));
            _wineries = response.Wineries;

            StateHasChanged();
        }
    }

    private void NavigateToWineryDetail(int wineryId)
    {
        _navigationManager.NavigateTo($"/Wineries/{wineryId}");
    }
}