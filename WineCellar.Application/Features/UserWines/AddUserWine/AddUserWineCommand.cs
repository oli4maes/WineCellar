namespace WineCellar.Application.Features.UserWines.AddUserWine;

public sealed record AddUserWineCommand(UserWineDto UserWineDto, string UserName, string Auth0Id) : IRequest<UserWineDto>;

public sealed class AddUserWineHandler : IRequestHandler<AddUserWineCommand, UserWineDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AddUserWineHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UserWineDto> Handle(AddUserWineCommand request, CancellationToken cancellationToken)
    {
        UserWine entity = new();
        entity.Auth0Id = request.Auth0Id;
        entity.WineId = request.UserWineDto.WineId;
        entity.Amount = request.UserWineDto.Amount;
        entity.CreatedBy = request.UserName;

        await _unitOfWork.UserWines.Create(entity);
        await _unitOfWork.CompleteAsync();

        return _mapper.Map<UserWineDto>(entity);
    }
}