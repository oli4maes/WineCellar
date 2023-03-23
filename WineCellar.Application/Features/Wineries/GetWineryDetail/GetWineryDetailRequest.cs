namespace WineCellar.Application.Features.Wineries.GetWineryDetail;

public sealed record GetWineryDetailRequest(int WineryId, string Auth0Id) : IRequest<GetWineryDetailResponse>;