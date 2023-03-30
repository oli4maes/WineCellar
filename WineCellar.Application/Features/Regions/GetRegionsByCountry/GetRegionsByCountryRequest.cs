namespace WineCellar.Application.Features.Regions.GetRegionsByCountry;

public sealed record GetRegionsByCountryRequest(int CountryId) : IRequest<GetRegionsByCountryResponse>;