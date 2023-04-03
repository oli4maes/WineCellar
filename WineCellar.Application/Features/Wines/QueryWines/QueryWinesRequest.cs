namespace WineCellar.Application.Features.Wines.QueryWines;

public sealed record QueryWinesRequest(string Query, string Auth0Id) : IRequest<QueryWinesResponse>;