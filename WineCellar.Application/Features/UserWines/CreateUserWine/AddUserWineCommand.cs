namespace WineCellar.Application.Features.UserWines.CreateUserWine;

public sealed record CreateUserWineCommand(UserWineDto UserWineDto, string UserName, string Auth0Id) : IRequest<UserWineDto>;

internal sealed class CreateUserWineHandler : IRequestHandler<CreateUserWineCommand, UserWineDto>
{
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMapper _mapper;

    public CreateUserWineHandler(IUserWineRepository userWineRepository, IMapper mapper)
    {
        _userWineRepository = userWineRepository;
        _mapper = mapper;
    }

    public async Task<UserWineDto> Handle(CreateUserWineCommand request, CancellationToken cancellationToken)
    {
        UserWine entity = new()
        {
            Auth0Id = request.Auth0Id,
            WineId = request.UserWineDto.WineId,
            Amount = request.UserWineDto.Amount,
            CreatedBy = request.UserName
        };

        await _userWineRepository.Create(entity);

        return _mapper.Map<UserWineDto>(entity);
    }
}