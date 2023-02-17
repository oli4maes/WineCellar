namespace WineCellar.Application.Features.Cellar.UpdateUserWine;

internal sealed class UpdateUserWineHandler : IRequestHandler<UpdateUserWineRequest>

{
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMapper _mapper;

    public UpdateUserWineHandler(IUserWineRepository userWineRepository, IMapper mapper)
    {
        _userWineRepository = userWineRepository;
        _mapper = mapper;
    }

    public async ValueTask<Unit> Handle(UpdateUserWineRequest request, CancellationToken cancellationToken)
    {
        UserWine userWineEntity = _mapper.Map<UserWine>(request.UserWineDto);
        userWineEntity.LastModifiedBy = request.UserName;

        await _userWineRepository.Update(userWineEntity);
        
        return Unit.Value;
    }
}