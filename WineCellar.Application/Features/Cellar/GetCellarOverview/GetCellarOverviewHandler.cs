namespace WineCellar.Application.Features.Cellar.GetCellarOverview;

internal sealed class GetCellarOverviewHandler : IRequestHandler<GetCellarOverviewRequest, GetCellarOverviewResponse>
{
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMapper _mapper;

    public GetCellarOverviewHandler(IUserWineRepository userWineRepository, IMapper mapper)
    {
        _userWineRepository = userWineRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetCellarOverviewResponse> Handle(GetCellarOverviewRequest request,
        CancellationToken cancellationToken)
    {
        var userWines = await _userWineRepository.GetUserWines(request.UserId);

        return new GetCellarOverviewResponse()
        {
            UserWines = userWines.Select(x => new GetCellarOverviewResponse.UserWineOverviewDto()
            {
                Id = x.Id,
                Amount = x.Amount,
                WineId = x.WineId,
                WineName = x.Wine.Name,
                WineType = x.Wine.WineType,
                WineryName = x.Wine.Winery.Name
            })
        };
    }
}