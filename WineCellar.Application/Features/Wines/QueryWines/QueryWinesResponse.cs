namespace WineCellar.Application.Features.Wines.QueryWines;

public sealed class QueryWinesResponse
{
    public List<WineDto> Wines { get; set; } = new();
}