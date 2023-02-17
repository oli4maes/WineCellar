namespace WineCellar.Application.Features.Cellar.GetUserWineDetail;

internal sealed class GetUserWineByIdHandler : IRequestHandler<GetUserWineDetailRequest, GetUserWineDetailResponse>
{
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMapper _mapper;

    public GetUserWineByIdHandler(IUserWineRepository userWineRepository, IMapper mapper)
    {
        _userWineRepository = userWineRepository;
        _mapper = mapper;
    }
    
    public async ValueTask<GetUserWineDetailResponse> Handle(GetUserWineDetailRequest request, CancellationToken cancellationToken)
    {
        var userWine = await _userWineRepository.GetById(request.Id);

        if (userWine?.Auth0Id != request.Auth0Id)
        {
            return null;
        }

        return new GetUserWineDetailResponse()
        {
            UserWine = _mapper.Map<UserWineDto>(userWine)
        };
    }
}