namespace WineCellar.Application.Features.Cellar.GetBottlesByWineId;

public sealed record GetBottlesByWineIdRequest(string Auth0Id, int WineId) : IRequest<GetBottlesByWineIdResponse>;