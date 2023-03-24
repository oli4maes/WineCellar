namespace WineCellar.Application.Features.Wineries.GetWineries;

public class GetWineriesResponse
{
    public List<WineryDto> Wineries { get; set; } = new();
}