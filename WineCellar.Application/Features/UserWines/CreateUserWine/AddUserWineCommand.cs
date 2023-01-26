namespace WineCellar.Application.Features.UserWines.CreateUserWine;

public sealed record CreateUserWineCommand(int WineId, int Amount, string UserName, string Auth0Id) : IRequest<UserWineDto>;

public sealed class CreateUserWineHandler : IRequestHandler<CreateUserWineCommand, UserWineDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateUserWineHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UserWineDto> Handle(CreateUserWineCommand request, CancellationToken cancellationToken)
    {
        UserWine entity = new()
        {
            Auth0Id = request.Auth0Id,
            WineId = request.WineId,
            Amount = request.Amount,
            CreatedBy = request.UserName
        };

        await _unitOfWork.UserWines.Create(entity);
        await _unitOfWork.CompleteAsync();

        return _mapper.Map<UserWineDto>(entity);
    }
}