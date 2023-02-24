namespace WineCellar.Application.Features.Wineries.GetWineryById;

public sealed class GetWineryByIdResponse
{
    public string? ErrorMessage { get; set; }
    public WineryDto? Winery { get; set; }
}