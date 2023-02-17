using WineCellar.Application.Features.Wineries.DeleteWinery;

namespace WineCellar.Application.Features.Wines.DeleteWine;

public sealed record DeleteWineRequest(int Id) : IRequest<DeleteWineResponse>;