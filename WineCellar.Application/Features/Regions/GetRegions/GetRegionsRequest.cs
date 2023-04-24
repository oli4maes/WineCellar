namespace WineCellar.Application.Features.Regions.GetRegions;

public sealed record GetRegionsRequest(string? Query, bool IsSpotlit = false) : IRequest<GetRegionsResponse>;