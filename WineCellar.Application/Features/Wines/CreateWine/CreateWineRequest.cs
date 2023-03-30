using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Wines.CreateWine;

public sealed record CreateWineRequest(string Name, WineType WineType, int WineryId, string UserName, int? RegionId) : IRequest<CreateWineResponse>;