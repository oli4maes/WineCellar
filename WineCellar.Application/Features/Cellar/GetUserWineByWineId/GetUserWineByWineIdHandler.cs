namespace WineCellar.Application.Features.Cellar.GetUserWineByWineId;

public sealed class GetUserWineByWineIdHandler : IRequestHandler<GetUserWineByWineIdRequest, GetUserWineByWineIdResponse>
{
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMapper _mapper;

    public GetUserWineByWineIdHandler(IUserWineRepository userWineRepository, IMapper mapper)
    {
        _userWineRepository = userWineRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetUserWineByWineIdResponse> Handle(GetUserWineByWineIdRequest request, CancellationToken cancellationToken)
    {
        var userWine = await _userWineRepository.GetByWineId(request.WineId);

        if (userWine?.Auth0Id != request.Auth0Id)
        {
            return null;
        }

        return new GetUserWineByWineIdResponse()
        {
            UserWine = _mapper.Map<UserWineDto>(userWine)
        };
    }
}