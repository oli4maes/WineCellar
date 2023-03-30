namespace WineCellar.Application.Features.Regions.GetRegionsByCountry;

public sealed class GetRegionsByCountryResponse
{
    public List<RegionDto> Regions { get; set; } = new();
}