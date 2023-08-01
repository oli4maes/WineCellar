namespace WineCellar.Application.Features.Wineries.GetWineryDetail;

public sealed class GetWineryDetailResponse
{
    public string? ErrorMessage { get; set; }
    public WineryDto? Winery { get; set; }
    public List<WineDto> Wines { get; set; } = new ();
}