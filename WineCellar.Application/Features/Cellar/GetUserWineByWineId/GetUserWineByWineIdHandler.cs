using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.GetUserWineByWineId;

public sealed class GetUserWineByWineIdHandler : IRequestHandler<GetUserWineByWineIdRequest, GetUserWineByWineIdResponse>
{
    private readonly IUserWineRepository _userWineRepository;

    public GetUserWineByWineIdHandler(IUserWineRepository userWineRepository)
    {
        _userWineRepository = userWineRepository;
    }

    public async ValueTask<GetUserWineByWineIdResponse> Handle(GetUserWineByWineIdRequest request, CancellationToken cancellationToken)
    {
        var userWine = await _userWineRepository.GetByWineId(request.WineId, request.Auth0Id);

        if (userWine?.Auth0Id != request.Auth0Id)
        {
            return new GetUserWineByWineIdResponse()
            {
                ErrorMessage = "You don't have access to this item."
            };
        }

        return new GetUserWineByWineIdResponse()
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