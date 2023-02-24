namespace WineCellar.Application.Features.Grapes.GetGrapeById;

public sealed class GetGrapeByIdResponse
{
    public string? ErrorMessage { get; set; }
    public GrapeDto? Grape { get; set; }
}