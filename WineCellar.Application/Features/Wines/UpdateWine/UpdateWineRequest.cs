﻿using WineCellar.Domain.Enums;

namespace WineCellar.Application.Features.Wines.UpdateWine;

public sealed record UpdateWineRequest(
        int Id,
        string Name,
        WineType WineType,
        string UserName,
        int? RegionId)
    : IRequest<UpdateWineResponse>;