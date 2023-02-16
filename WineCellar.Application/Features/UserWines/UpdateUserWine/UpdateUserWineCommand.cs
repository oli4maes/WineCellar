namespace WineCellar.Application.Features.UserWines.UpdateUserWine;

public sealed record UpdateUserWineCommand(UserWineDto UserWineDto, string UserName) : IRequest;

internal sealed class UpdateUserWineHandler : IRequestHandler<UpdateUserWine>

{
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMapper _mapper;

    public UpdateUserWineHandler(IUserWineRepository userWineRepository, IMapper mapper)
    {
        _userWineRepository = userWineRepository;
        _mapper = mapper;
    }

    public async ValueTask<Unit> Handle(UpdateUserWine request, CancellationToken cancellationToken)
    {
        UserWine userWineEntity = _mapper.Map<UserWine>(request.UserWineDto);
        userWineEntity.LastModifiedBy = request.UserName;

        await _userWineRepository.Update(userWineEntity);
        
        return Unit.Value;
    }
}