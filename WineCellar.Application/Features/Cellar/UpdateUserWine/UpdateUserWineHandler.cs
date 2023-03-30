using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.UpdateUserWine;

internal sealed class UpdateUserWineHandler : IRequestHandler<UpdateUserWineRequest, UpdateUserWineResponse>

{
    private readonly IUserWineRepository _userWineRepository;
    public UpdateUserWineHandler(IUserWineRepository userWineRepository)
    {
        _userWineRepository = userWineRepository;
    }

    public async ValueTask<UpdateUserWineResponse> Handle(UpdateUserWineRequest request, CancellationToken cancellationToken)
    {
        var userWine = await _userWineRepository.GetById(request.Id);

        if (userWine?.Auth0Id != request.Auth0Id)
        {
            return new UpdateUserWineResponse()
            {
                ErrorMessage = "You don't have access to this item."
            };
        }

        userWine.Amount = request.Amount;
        userWine.LastModifiedBy = request.UserName;

        await _userWineRepository.Update(userWine);

        return new UpdateUserWineResponse();
    }
}