namespace WineCellar.Application.Features.UserWines.UpdateUserWine;

public sealed record UpdateUserWine(UserWineDto UserWineDto, string UserName) : IRequest;

public sealed class UpdateUserWineHandler : IRequestHandler<UpdateUserWine>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateUserWineHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async ValueTask<Unit> Handle(UpdateUserWine request, CancellationToken cancellationToken)
    {
        UserWine userWineEntity = _mapper.Map<UserWine>(request.UserWineDto);
        userWineEntity.LastModifiedBy = request.UserName;

        await _unitOfWork.UserWines.Update(userWineEntity);
        await _unitOfWork.CompleteAsync();
        
        return Unit.Value;
    }
}