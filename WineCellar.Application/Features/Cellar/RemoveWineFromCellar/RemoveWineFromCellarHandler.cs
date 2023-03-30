using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.RemoveWineFromCellar;

internal sealed class RemoveWineFromCellarHandler : IRequestHandler<RemoveWineFromCellarRequest, RemoveWineFromCellarResponse> 
{
    private readonly IUserWineRepository _userWineRepository;

    public RemoveWineFromCellarHandler(IUserWineRepository userWineRepository)
    {
        _userWineRepository = userWineRepository;
    }

    public async ValueTask<RemoveWineFromCellarResponse> Handle(RemoveWineFromCellarRequest request, CancellationToken cancellationToken)
    {
        bool success = await _userWineRepository.Delete(request.Id);

        return new RemoveWineFromCellarResponse()
        {
            SuccessfulDelete = success
        };
    }
} 