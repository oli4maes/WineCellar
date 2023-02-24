namespace WineCellar.Application.Features.Cellar.GetCellarOverview;

public sealed record GetCellarOverviewRequest(string Auth0Id) : IRequest<GetCellarOverviewResponse>;