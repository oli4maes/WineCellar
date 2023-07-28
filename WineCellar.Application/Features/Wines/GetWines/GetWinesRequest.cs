﻿namespace WineCellar.Application.Features.Wines.GetWines;

public sealed record GetWinesRequest
    (string? Query, string? Auth0Id, bool ClearCache = false) : IRequest<GetWinesResponse>;