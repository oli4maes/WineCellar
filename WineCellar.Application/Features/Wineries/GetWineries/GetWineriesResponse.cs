namespace WineCellar.Application.Features.Wineries.GetWineries;

public class GetWineriesResponse
{
    public IEnumerable<WineryDto> Wineries { get; set; } = new List<WineryDto>();
}