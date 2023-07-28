using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.DeleteBottle;

internal sealed class DeleteBottleHandler : IRequestHandler<DeleteBottleRequest, DeleteBottleResponse>
{
    private readonly IBottleRepository _bottleRepository;

    public DeleteBottleHandler(IBottleRepository bottleRepository)
    {
        _bottleRepository = bottleRepository;
    }
    
    public async ValueTask<DeleteBottleResponse> Handle(DeleteBottleRequest request, CancellationToken cancellationToken)
    {
        bool succes = await _bottleRepository.Delete(request.BottleId);
        
        return new DeleteBottleResponse()
        {
            SuccessfulDelete = succes
        };
    }
}