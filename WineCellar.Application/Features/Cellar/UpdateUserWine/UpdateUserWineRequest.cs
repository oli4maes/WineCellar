namespace WineCellar.Application.Features.Cellar.UpdateUserWine;

public sealed record UpdateUserWineRequest(int Id, int Amount, string UserName, string Auth0Id) : IRequest<UpdateUserWineResponse>;