namespace WineCellar.Application.Features.Regions.GetRegions;

public sealed class GetRegionsResponse
{
    public List<RegionDto> Regions { get; set; } = new();
}