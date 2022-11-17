﻿namespace WineCellar.Application.Common.Mapper;

public sealed class GrapeProfile : Profile
{
	public GrapeProfile()
	{
		// Source -> Target
		CreateMap<Grape, GrapeDto>();
		CreateMap<GrapeDto, Grape>();
	}
}
