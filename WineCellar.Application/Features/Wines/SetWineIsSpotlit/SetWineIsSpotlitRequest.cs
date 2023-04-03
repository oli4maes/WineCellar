namespace WineCellar.Application.Features.Wines.SetWineIsSpotlit;

public sealed record SetWineIsSpotlitRequest(int WineryId, string UserName) : IRequest<SetWineIsSpotlitResponse>;