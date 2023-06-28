namespace WineCellar.Blazor.Features.Administration.Regions.Components;

public partial class RegionsTable : ComponentBase
{
    [Parameter] public IEnumerable<RegionDto> Regions { get; set; }

    private MudDataGrid<RegionDto> _dataGrid;

    private string _searchString = String.Empty;

    // Quick filter - filter globally across multiple columns (Name) with the same input
    private Func<RegionDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };
}