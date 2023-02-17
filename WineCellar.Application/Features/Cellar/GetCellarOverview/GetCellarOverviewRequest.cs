namespace WineCellar.Application.Features.Cellar.GetCellarOverview;

public sealed record GetCellarOverviewRequest(string UserId) : IRequest<GetCellarOverviewResponse>;