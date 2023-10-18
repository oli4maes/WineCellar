namespace WineCellar.Application.Features.Wines.GetWines;

public sealed record GetWinesRequest(
        string? Query,
        string? Auth0Id,
        int? WineryId,
        bool ClearCache = false)
    : IRequest<GetWinesResponse>;