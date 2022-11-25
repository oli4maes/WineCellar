namespace WineCellar.Application.Common.Mapper;

public class UserWineProfile : Profile
{
	public UserWineProfile()
	{
		// Source -> Target
		CreateMap<UserWine, UserWineDto>();
		CreateMap<UserWineDto, UserWine>();
	}
}
