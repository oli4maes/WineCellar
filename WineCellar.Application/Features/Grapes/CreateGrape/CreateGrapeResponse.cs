namespace WineCellar.Application.Features.Grapes.CreateGrape;

public sealed class CreateGrapeResponse
{
    public string? ErrorMessage { get; set; }
    public GrapeDto Grape { get; set; } = new();
}