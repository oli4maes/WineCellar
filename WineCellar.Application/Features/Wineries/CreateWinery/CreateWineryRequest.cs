namespace WineCellar.Application.Features.Wineries.CreateWinery;

public sealed record CreateWineryRequest(WineryDto WineryDto, string UserName) : IRequest<CreateWineryResponse>;