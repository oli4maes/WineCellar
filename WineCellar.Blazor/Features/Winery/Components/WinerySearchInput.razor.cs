namespace WineCellar.Blazor.Features.Winery.Components;

public partial class WinerySearchInput : ComponentBase
{
    [Parameter] public EventCallback<string> OnSearchWineries { get; set; }

    private string QueryString { get; set; } = String.Empty;

    private async void SearchWineries()
    {
        await OnSearchWineries.InvokeAsync(QueryString);
    }
}