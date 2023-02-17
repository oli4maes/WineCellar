namespace WineCellar.Application.Features.UserWines.GetUserWineDetail;

public sealed record GetUserWineDetailRequest(int Id, string Auth0Id) : IRequest<UserWineDto?>;