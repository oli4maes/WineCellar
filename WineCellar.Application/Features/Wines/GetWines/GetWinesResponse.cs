namespace WineCellar.Application.Features.Wines.GetWines;

public sealed class GetWinesResponse
{
    public IEnumerable<WineDto> Wines { get; set; } = new List<WineDto>();
}