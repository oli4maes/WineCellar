namespace WineCellar.Application.Profiles;

public class WineProfile : Profile
{
	public WineProfile()
	{
		// Source -> Target
		CreateMap<Wine, WineDto>();
		CreateMap<WineDto, Wine>();
	}
}
