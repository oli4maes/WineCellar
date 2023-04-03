namespace WineCellar.Application.Features.Wines.GetWines;

public sealed record GetWinesRequest(string? Auth0Id, bool IsSpotlit = false) : IRequest<GetWinesResponse>;