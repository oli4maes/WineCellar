namespace WineCellar.Blazor.Features.Wine.Components;

public partial class GrapesList : ComponentBase
{
    [Parameter] public List<GrapeDto> Grapes { get; set; } = new();
}