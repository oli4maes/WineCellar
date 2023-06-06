namespace WineCellar.Application.Features.Regions.SetRegionsIsSpotlit;

public sealed record SetRegionIsSpotlitRequest(int RegionId, string UserName) : IRequest<SetRegionIsSpotlitResponse>;