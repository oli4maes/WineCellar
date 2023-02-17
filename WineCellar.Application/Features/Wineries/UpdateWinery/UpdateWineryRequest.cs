namespace WineCellar.Application.Features.Wineries.UpdateWinery;

public sealed record UpdateWineryRequest(WineryDto WineryDto, string UserName) : IRequest;