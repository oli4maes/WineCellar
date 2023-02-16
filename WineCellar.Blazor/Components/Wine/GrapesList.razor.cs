namespace WineCellar.Blazor.Components.Wine;

public partial class GrapesList : ComponentBase
{
    [Parameter] public List<GrapeDto> Grapes { get; set; }
}