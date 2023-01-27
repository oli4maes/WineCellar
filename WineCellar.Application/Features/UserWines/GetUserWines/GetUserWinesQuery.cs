namespace WineCellar.Application.Features.UserWines.GetUserWines;

public sealed record GetUserWinesQuery(string UserId) : IRequest<List<UserWineDto>>;

internal sealed class GetUserWinesHandler : IRequestHandler<GetUserWinesQuery, List<UserWineDto>>
{
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMapper _mapper;

    public GetUserWinesHandler(IUserWineRepository userWineRepository, IMapper mapper)
    {
        _userWineRepository = userWineRepository;
        _mapper = mapper;
    }

    public async Task<List<UserWineDto>> Handle(GetUserWinesQuery request, CancellationToken cancellationToken)
    {
        var userWines = await _userWineRepository.GetUserWines(request.UserId);

        return _mapper.Map<List<UserWineDto>>(userWines);
    }
}
