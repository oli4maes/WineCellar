using WineCellar.Application.Features.Wineries.GetWineryDetail;

namespace WineCellar.Blazor.Features.Winery.Components;

public partial class WineCard : ComponentBase
{
    [Parameter] public GetWineryDetailResponse.WineDto Wine { get; set; }
}