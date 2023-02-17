namespace WineCellar.Application.Features.Wineries.GetWineryById;

public sealed record GetWineryByIdRequest(int Id) : IRequest<GetWineryByIdResponse>;