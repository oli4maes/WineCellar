using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Regions.SetRegionsIsSpotlit;

public class SetRegionIsSpotlitHandler : IRequestHandler<SetRegionIsSpotlitRequest, SetRegionIsSpotlitResponse>
{
    private readonly IRegionRepository _regionRepository;

    public SetRegionIsSpotlitHandler(IRegionRepository regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public async ValueTask<SetRegionIsSpotlitResponse> Handle(SetRegionIsSpotlitRequest request, CancellationToken cancellationToken)
    {
        var succes = await _regionRepository.ToggleIsSpotlit(request.RegionId, request.UserName);

        if (succes)
        {
            return new SetRegionIsSpotlitResponse();
        }

        return new SetRegionIsSpotlitResponse()
        {
            ErrorMessage = $"Couldn't toggle spotlit for region with id: {request.RegionId}."
        };
    }
}