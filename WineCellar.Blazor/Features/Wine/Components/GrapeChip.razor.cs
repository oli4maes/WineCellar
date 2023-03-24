namespace WineCellar.Blazor.Features.Wine.Components;

public partial class GrapeChip : ComponentBase
{
    [Parameter] public GrapeDto Grape { get; set; }

    private string _grapeTypeColor { get; set; } = String.Empty;
    private string _grapeTypeTextColor { get; set; } = String.Empty;

    protected override async Task OnInitializedAsync()
    {
        SetGrapeTypeColor();
    }

    private void SetGrapeTypeColor()
    {
        switch (Grape.GrapeType)
        {
            case GrapeType.White:
                _grapeTypeColor = Colors.Green.Lighten4;
                _grapeTypeTextColor = Colors.Grey.Darken4;
                break;
            case GrapeType.Pink:
                _grapeTypeColor = Colors.Pink.Lighten4;
                _grapeTypeTextColor = Colors.Grey.Darken4;
                break;
            case GrapeType.Black:
                _grapeTypeColor = Colors.Purple.Lighten4;
                _grapeTypeTextColor = Colors.Grey.Darken4;
                break;
        }
    }
}