namespace WineCellar.Application.Features.Wineries.QueryWineries;

public sealed record QueryWineriesRequest(string Query) : IRequest<QueryWineriesResponse>;