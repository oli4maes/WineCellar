using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Wineries.GetWineryDetail;

public sealed class GetWineryDetailResponse
{
    public string? ErrorMessage { get; set; }
    public WineryDto? Winery { get; set; }
    public IEnumerable<WineDto> Wines { get; set; } = new List<WineDto>();

    public sealed class WineDto
    {
        public string Name { get; set; } = String.Empty;
        public WineType WineType { get; set; }
        public bool IsInUserCellar { get; set; }
    }
}