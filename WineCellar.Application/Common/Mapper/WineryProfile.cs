namespace WineCellar.Application.Common.Mapper;

public sealed class WineryProfile : Profile
{
    public WineryProfile()
    {
        // Source -> Target
        CreateMap<Winery, WineryDto>();
        CreateMap<WineryDto, Winery>();
    }
}
