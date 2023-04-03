using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wines.SetWineIsSpotlit;

public class SetWineIsSpotlitHandler : IRequestHandler<SetWineIsSpotlitRequest, SetWineIsSpotlitResponse>
{
    private readonly IWineRepository _wineRepository;

    public SetWineIsSpotlitHandler(IWineRepository wineRepository)
    {
        _wineRepository = wineRepository;
    }
    
    public async ValueTask<SetWineIsSpotlitResponse> Handle(SetWineIsSpotlitRequest request, CancellationToken cancellationToken)
    {
        var success = await _wineRepository.ToggleIsSpotlit(request.WineryId, request.UserName);

        if (success)
        {
            return new SetWineIsSpotlitResponse();
        }

        return new SetWineIsSpotlitResponse()
        {
            ErrorMessage = $"Couldn't toggle spotlit for wine with id: {request.WineryId}."
        };
    }
}