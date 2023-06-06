namespace WineCellar.Blazor.Features.Administration.Regions.Components;

public partial class RegionsTable : ComponentBase
{
    [Parameter] public IEnumerable<RegionDto> Regions { get; set; }
    [Parameter] public EventCallback<RegionDto> OnToggleSpotlit { get; set; }

    private MudDataGrid<RegionDto> _dataGrid;

    private void ToggleIsSpotlit(RegionDto region)
    {
        OnToggleSpotlit.InvokeAsync(region);
    }
}