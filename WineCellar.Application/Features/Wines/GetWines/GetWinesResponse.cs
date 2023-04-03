namespace WineCellar.Application.Features.Wines.GetWines;

public sealed class GetWinesResponse
{
    public List<WineDto> Wines { get; set; } = new ();
}