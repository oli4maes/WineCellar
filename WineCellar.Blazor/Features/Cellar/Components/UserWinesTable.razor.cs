using WineCellar.Application.Features.Cellar.GetCellarOverview;

namespace WineCellar.Blazor.Features.Cellar.Components;

public partial class UserWinesTable : ComponentBase
{
    [Parameter] public IEnumerable<GetCellarOverviewResponse.UserWineOverviewDto> UserWines { get; set; }
    [Parameter] public bool Loading { get; set; }
    [Parameter] public EventCallback<GetCellarOverviewResponse.UserWineOverviewDto> OnOpenWine { get; set; }
    [Parameter] public EventCallback<int> OnRemoveBottle { get; set; }
    [Parameter] public EventCallback<int> OnAddBottle { get; set; }

    private string _searchString { get; set; } = string.Empty;

    private void RowClickEvent(TableRowClickEventArgs<GetCellarOverviewResponse.UserWineOverviewDto> eventArgs)
    {
        OnOpenWine.InvokeAsync(eventArgs.Item);
    }

    private bool FilterFunc(GetCellarOverviewResponse.UserWineOverviewDto item) => FilterFunc(item, _searchString);

    private bool FilterFunc(GetCellarOverviewResponse.UserWineOverviewDto item, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (item.WineName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (item.WineryName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }

    private void RemoveBottle(int userWineId)
    {
        OnRemoveBottle.InvokeAsync(userWineId);
    }

    private void AddBottle(int userWineId)
    {
        OnAddBottle.InvokeAsync(userWineId);
    }
}