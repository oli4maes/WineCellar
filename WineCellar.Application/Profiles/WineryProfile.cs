namespace WineCellar.Application.Profiles;

public sealed class WineryProfile : Profile
{
    public WineryProfile()
    {
        // Source -> Target
        CreateMap<Winery, WineryDto>();
        CreateMap<WineryDto, Winery>();
    }
}
