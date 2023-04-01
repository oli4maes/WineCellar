namespace WineCellar.Application.Features.Wineries.CreateWinery;

public sealed class CreateWineryResponse
{
    public string? ErrorMessage { get; set; }
    public WineryDto Winery { get; set; } = new();
}