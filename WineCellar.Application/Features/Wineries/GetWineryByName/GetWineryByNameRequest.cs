namespace WineCellar.Application.Features.Wineries.GetWineryByName;

public sealed record GetWineryByNameRequest(string Name) : IRequest<GetWineryByNameResponse>;