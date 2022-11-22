using WineCellar.Application.Wines.Dto;

namespace WineCellar.Application.Common.Mapper;

public class WineProfile : Profile
{
	public WineProfile()
	{
		// Source -> Target
		CreateMap<Wine, WineDto>();
		CreateMap<WineDto, Wine>();
	}
}
