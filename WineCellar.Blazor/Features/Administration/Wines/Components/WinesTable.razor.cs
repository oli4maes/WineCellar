namespace WineCellar.Blazor.Features.Administration.Wines.Components;

public partial class WinesTable : ComponentBase
{
    [Parameter] public IEnumerable<WineDto> Wines { get; set; }
    [Parameter] public EventCallback<WineDto> OnToggleIsSpotlit { get; set; }
    [Parameter] public EventCallback<WineDto> OnOpenWine { get; set; }
    [Parameter] public EventCallback<WineDto> OnDeleteWine { get; set; }

    private string _searchString = String.Empty;

    // Quick filter - filter globally across multiple columns (Name) with the same input
    private Func<WineDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };

    private void ToggleIsSpotlit(WineDto wine)
    {
        OnToggleIsSpotlit.InvokeAsync(wine);
    }

    private void OpenWine(WineDto wine)
    {
        OnOpenWine.InvokeAsync(wine);
    }

    private void DeleteWine(WineDto wine)
    {
        OnDeleteWine.InvokeAsync(wine);
    }
}