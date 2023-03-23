using System.Security.Claims;
using WineCellar.Application.Features.Wineries.GetWineryDetail;

namespace WineCellar.Blazor.Features.Winery.Pages;

public partial class Detail : ComponentBase
{
    [Parameter] public int Id { get; set; }
    [Inject] private IMediator _mediator { get; set; }
    [Inject] private AuthenticationStateProvider _authenticationStateProvider { get; set; }

    private string _auth0Id { get; set; } = String.Empty;
    private WineryDto _winery { get; set; }

    private IEnumerable<GetWineryDetailResponse.WineDto> _wines { get; set; } =
        new List<GetWineryDetailResponse.WineDto>();

    protected override async Task OnInitializedAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        _auth0Id = authState.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;

        var getWineryByIdResponse = await _mediator.Send(new GetWineryDetailRequest(Id, _auth0Id));
        _winery = getWineryByIdResponse.Winery ?? new WineryDto();
        _wines = getWineryByIdResponse.Wines;
    }
}