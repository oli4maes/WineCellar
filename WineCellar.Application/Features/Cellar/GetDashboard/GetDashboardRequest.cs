namespace WineCellar.Application.Features.Cellar.GetDashboard;

public sealed record GetDashboardRequest(string Auth0Id) : IRequest<GetDashboardResponse>;