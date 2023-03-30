using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.AddWineToCellar;

internal sealed class AddWineToCellarHandler : IRequestHandler<AddWineToCellarRequest, AddWineToCellarResponse>
{
    private readonly IUserWineRepository _userWineRepository;

    public AddWineToCellarHandler(IUserWineRepository userWineRepository)
    {
        _userWineRepository = userWineRepository;
    }

    public async ValueTask<AddWineToCellarResponse> Handle(AddWineToCellarRequest request,
        CancellationToken cancellationToken)
    {
        UserWine userWine = new()
        {
            Auth0Id = request.Auth0Id,
            WineId = request.WineId,
            Amount = request.Amount,
            CreatedBy = request.UserName
        };

        await _userWineRepository.Create(userWine);

        return new AddWineToCellarResponse()
        {
            UserWine = new UserWineDto()
            {
                Id = userWine.Id,
                Amount = userWine.Amount,
                WineId = userWine.WineId
            }
        };
    }
}