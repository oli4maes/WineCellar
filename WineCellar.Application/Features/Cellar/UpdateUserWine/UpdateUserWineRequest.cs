namespace WineCellar.Application.Features.Cellar.UpdateUserWine;

public sealed record UpdateUserWineRequest(UserWineDto UserWineDto, string UserName) : IRequest;