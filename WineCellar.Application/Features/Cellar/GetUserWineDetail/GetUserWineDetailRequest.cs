namespace WineCellar.Application.Features.Cellar.GetUserWineDetail;

public sealed record GetUserWineDetailRequest(int Id, string Auth0Id) : IRequest<GetUserWineDetailResponse>;