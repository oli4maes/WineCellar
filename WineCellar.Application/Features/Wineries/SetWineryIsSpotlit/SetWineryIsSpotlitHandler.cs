using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wineries.SetWineryIsSpotlit;

internal sealed class SetWineryIsSpotlitHandler : IRequestHandler<SetWineryIsSpotlitRequest, SetWineryIsSpotlitResponse>
{
    private readonly IWineryRepository _wineryRepository;

    public SetWineryIsSpotlitHandler(IWineryRepository wineryRepository)
    {
        _wineryRepository = wineryRepository;
    }
    
    public async ValueTask<SetWineryIsSpotlitResponse> Handle(SetWineryIsSpotlitRequest request, CancellationToken cancellationToken)
    {
        var success = await _wineryRepository.ToggleIsSpotlit(request.WineryId, request.UserName);

        if (success)
        {
            return new SetWineryIsSpotlitResponse();
        }

        return new SetWineryIsSpotlitResponse()
        {
            ErrorMessage = $"Couldn't toggle spotlit for winery with id: {request.WineryId}."
        };
    }
}