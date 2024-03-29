﻿namespace WineCellar.Application.Features.Wineries.CreateWinery;

public sealed record CreateWineryRequest(
        string Name,
        string? Description,
        string UserName,
        int? CountryId)
    : IRequest<CreateWineryResponse>;