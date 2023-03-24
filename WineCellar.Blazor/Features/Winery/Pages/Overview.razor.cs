using WineCellar.Application.Features.Wineries.QueryWineries;

namespace WineCellar.Blazor.Features.Winery.Pages;

public partial class Overview : ComponentBase
{
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }

    private List<WineryDto> _wineries { get; set; } = new();

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