namespace WineCellar.Application.Features.Cellar.GetUserWineByWineId;

public sealed record GetUserWineByWineIdRequest(string Auth0Id, int WineId) : IRequest<GetUserWineByWineIdResponse>;