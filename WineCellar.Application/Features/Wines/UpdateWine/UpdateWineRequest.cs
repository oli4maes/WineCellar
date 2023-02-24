using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Wines.UpdateWine;

public sealed record UpdateWineRequest
    (int Id, string Name, WineType WineType, int WineryId, string UserName) : IRequest<UpdateWineResponse>;