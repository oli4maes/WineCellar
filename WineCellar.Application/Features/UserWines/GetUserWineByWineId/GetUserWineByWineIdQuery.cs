namespace WineCellar.Application.Features.UserWines.GetUserWineByWineId;

public record GetUserWineByWineIdQuery(string Auth0Id, int WineId) : IRequest<UserWineDto?>;

public sealed class GetUserWineByWineIdHandler : IRequestHandler<GetUserWineByWineIdQuery, UserWineDto?>
{
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMapper _mapper;

    public GetUserWineByWineIdHandler(IUserWineRepository userWineRepository, IMapper mapper)
    {
        _userWineRepository = userWineRepository;
        _mapper = mapper;
    }

    public async ValueTask<UserWineDto?> Handle(GetUserWineByWineIdQuery request, CancellationToken cancellationToken)
    {
        var userWine = await _userWineRepository.GetByWineId(request.WineId);

        if (userWine?.Auth0Id != request.Auth0Id)
        {
            return null;
        }

        return _mapper.Map<UserWineDto>(userWine);
    }
}