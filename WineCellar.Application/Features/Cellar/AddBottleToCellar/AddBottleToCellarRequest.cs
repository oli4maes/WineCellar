﻿using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Cellar.AddBottleToCellar;

public sealed record AddBottleToCellarRequest(int WineId, BottleSize BottleSize, string UserName, string Auth0Id, int? Vintage = null) : IRequest<AddBottleToCellarResponse>;