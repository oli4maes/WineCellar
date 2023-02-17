namespace WineCellar.Application.Features.Cellar.AddWineToCellar;

internal sealed class AddWineToCellarHandler : IRequestHandler<AddWineToCellarRequest, AddWineToCellarResponse>
{
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMapper _mapper;

    public AddWineToCellarHandler(IUserWineRepository userWineRepository, IMapper mapper)
    {
        _userWineRepository = userWineRepository;
        _mapper = mapper;
    }

    public async ValueTask<AddWineToCellarResponse> Handle(AddWineToCellarRequest request,
        CancellationToken cancellationToken)
    {
        UserWine entity = new()
        {
            Auth0Id = request.Auth0Id,
            WineId = request.WineId,
            Amount = request.Amount,
            CreatedBy = request.UserName
        };

        await _userWineRepository.Create(entity);

        return new AddWineToCellarResponse()
        {
            UserWine = _mapper.Map<UserWineDto>(entity)
        };
    }
}