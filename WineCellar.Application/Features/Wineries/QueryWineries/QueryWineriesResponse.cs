namespace WineCellar.Application.Features.Wineries.QueryWineries;

public class QueryWineriesResponse
{
    public List<WineryDto> Wineries { get; set; } = new();
}