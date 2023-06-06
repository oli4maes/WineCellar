namespace WineCellar.Blazor.Features.Administration.Wineries.Components;

public partial class WineriesTable : ComponentBase
{
    [Parameter] public IEnumerable<WineryDto> Wineries { get; set; }
    [Parameter] public EventCallback<WineryDto> OnToggleIsSpotlit { get; set; }
    [Parameter] public EventCallback<WineryDto> OnOpenWinery { get; set; }
    [Parameter] public EventCallback<WineryDto> OnDeleteWinery { get; set; }

    private string _searchString = String.Empty;

    // Quick filter - filter globally across multiple columns (Name) with the same input
    private Func<WineryDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };

    private void ToggleIsSpotlit(WineryDto winery)
    {
        OnToggleIsSpotlit.InvokeAsync(winery);
    }

    private void OpenWinery(WineryDto winery)
    {
        OnOpenWinery.InvokeAsync(winery);
    }

    private void DeleteWinery(WineryDto winery)
    {
        OnDeleteWinery.InvokeAsync(winery);
    }
}