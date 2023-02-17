namespace WineCellar.Application.Features.Wineries.DeleteWinery;

public sealed record DeleteWineryRequest(int Id) : IRequest<DeleteWineryResponse>;