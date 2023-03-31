namespace WineCellar.Application.Features.Wineries.SetWineryIsSpotlit;

public sealed record SetWineryIsSpotlitRequest(int WineryId, string UserName) : IRequest<SetWineryIsSpotlitResponse>;