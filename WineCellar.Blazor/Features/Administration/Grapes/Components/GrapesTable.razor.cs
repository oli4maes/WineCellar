using Microsoft.AspNetCore.Mvc;

namespace WineCellar.Blazor.Features.Administration.Grapes.Components;

public partial class GrapesTable : ComponentBase
{
    [Parameter] public IEnumerable<GrapeDto> Grapes { get; set; }
    [Parameter] public EventCallback<GrapeDto> OnOpenGrape { get; set; }
    [Parameter] public EventCallback<GrapeDto> OnDeleteGrape { get; set; }
    
    private string _searchString = String.Empty;
    
    // Quick filter - filter globally across multiple columns (Name) with the same input
    private Func<GrapeDto, bool> QuickFilter => x =>
    {
        if (string.IsNullOrWhiteSpace(_searchString))
            return true;

        if (x.Name.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    };

    private void OpenGrape(GrapeDto grape)
    {
        OnOpenGrape.InvokeAsync(grape);
    }

    private void DeleteGrape(GrapeDto grape)
    {
        OnDeleteGrape.InvokeAsync(grape);
    }
}