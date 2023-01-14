namespace WineCellar.Application.Profiles;

public class UserWineProfile : Profile
{
	public UserWineProfile()
	{
		// Source -> Target
		CreateMap<UserWine, UserWineDto>();
		CreateMap<UserWineDto, UserWine>();
	}
}
