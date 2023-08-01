namespace WineCellar.Application.Features.Wines.RemoveGrapeFromWine;

public sealed record RemoveGrapeFromWineRequest(
        int GrapeId,
        int WineId)
    : IRequest<RemoveGrapeFromWineResponse>;