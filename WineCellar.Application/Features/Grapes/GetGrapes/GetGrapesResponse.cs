namespace WineCellar.Application.Features.Grapes.GetGrapes;

public sealed class GetGrapesResponse
{
    public List<GrapeDto> Grapes { get; set; } = new();
}