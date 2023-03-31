namespace WineCellar.Application.Features.Wineries.GetWineries;

public sealed record GetWineriesRequest(bool IsSpotlit = false) : IRequest<GetWineriesResponse>;