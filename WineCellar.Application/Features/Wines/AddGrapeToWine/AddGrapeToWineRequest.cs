namespace WineCellar.Application.Features.Wines.AddGrapeToWine;

public sealed record AddGrapeToWineRequest(int GrapeId, int WineId) : IRequest<AddGrapeToWineResponse>;