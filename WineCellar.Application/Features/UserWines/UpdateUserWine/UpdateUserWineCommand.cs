namespace WineCellar.Application.Features.UserWines.UpdateUserWine;

public sealed record UpdateUserWineCommand(UserWineDto UserWineDto, string UserName) : IRequest;

internal sealed class UpdateUserWineHandler : IRequestHandler<UpdateUserWineCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateUserWineHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateUserWineCommand request, CancellationToken cancellationToken)
    {
        UserWine userWineEntity = _mapper.Map<UserWine>(request.UserWineDto);
        userWineEntity.LastModifiedBy = request.UserName;

        await _unitOfWork.UserWines.Update(userWineEntity);
        await _unitOfWork.CompleteAsync();
        
        return Unit.Value;
    }
}