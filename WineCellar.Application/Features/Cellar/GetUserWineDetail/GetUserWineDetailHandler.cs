using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.GetUserWineDetail;

internal sealed class GetUserWineByIdHandler : IRequestHandler<GetUserWineDetailRequest, GetUserWineDetailResponse>
{
    private readonly IUserWineRepository _userWineRepository;

    public GetUserWineByIdHandler(IUserWineRepository userWineRepository)
    {
        _userWineRepository = userWineRepository;
    }
    
    public async ValueTask<GetUserWineDetailResponse> Handle(GetUserWineDetailRequest request, CancellationToken cancellationToken)
    {
        var userWine = await _userWineRepository.GetById(request.Id);

        if (userWine?.Auth0Id != request.Auth0Id)
        {
            return new GetUserWineDetailResponse()
            {
                ErrorMessage = "You don't have access to this item."
            };
        }

        return new GetUserWineDetailResponse()
        {
            UserWine = new UserWineDto()
            {
                Id = userWine.Id,
                Amount = userWine.Amount,
                WineId = userWine.WineId,
                Wine = new WineDto()
                {
                    Id = userWine.Wine!.Id,
                    Name = userWine.Wine.Name,
                    WineType = userWine.Wine.WineType,
                    Winery = new WineryDto()
                    {
                        Id = userWine.Wine.WineryId,
                        Name = userWine.Wine.Winery.Name,
                        Description = userWine.Wine.Winery.Description
                    }
                }
            }
        };
    }
}