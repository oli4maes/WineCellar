namespace WineCellar.Application.Features.UserWines.DeleteUserWine;

public sealed record DeleteUserWineCommand(int Id) : IRequest<bool>;

internal sealed class DeleteUserWineHandler : IRequestHandler<DeleteUserWineCommand, bool> 
{
    private readonly IUserWineRepository _userWineRepository;

    public DeleteUserWineHandler(IUserWineRepository userWineRepository)
    {
        _userWineRepository = userWineRepository;
    }

    public async Task<bool> Handle(DeleteUserWineCommand request, CancellationToken cancellationToken)
    {
        bool success = await _userWineRepository.Delete(request.Id);

        return success;
    }
} 