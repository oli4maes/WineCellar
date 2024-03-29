﻿using WineCellar.Application.Features.Cellar.GetCellarOverview;

namespace WineCellar.Blazor.Features.Cellar.Components;

public partial class UserWinesTable : ComponentBase
{
    [Parameter]
    public IEnumerable<GetCellarOverviewResponse.CellarOverviewDto> UserWines { get; set; } =
        new List<GetCellarOverviewResponse.CellarOverviewDto>();

    [Parameter] public bool Loading { get; set; }
    [Parameter] public EventCallback<GetCellarOverviewResponse.CellarOverviewDto> OnOpenWine { get; set; }

    private string SearchString { get; set; } = string.Empty;

    private void RowClickEvent(TableRowClickEventArgs<GetCellarOverviewResponse.CellarOverviewDto> eventArgs)
    {
        OnOpenWine.InvokeAsync(eventArgs.Item);
    }

    private bool FilterFunc(GetCellarOverviewResponse.CellarOverviewDto item) => FilterFunc(item, SearchString);

    private bool FilterFunc(GetCellarOverviewResponse.CellarOverviewDto item, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (item.WineName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (item.WineryName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
}