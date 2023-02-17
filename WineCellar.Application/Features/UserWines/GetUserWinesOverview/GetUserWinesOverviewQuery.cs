namespace WineCellar.Application.Features.UserWines.GetUserWinesOverview;

public sealed record GetUserWinesOverviewQuery(string UserId) : IRequest<GetUserWinesOverviewResponse>;

internal sealed class GetUserWinesOverviewHandler : IRequestHandler<GetUserWinesOverviewQuery, GetUserWinesOverviewResponse>
{
    private readonly IUserWineRepository _userWineRepository;
    private readonly IMapper _mapper;

    public GetUserWinesOverviewHandler(IUserWineRepository userWineRepository, IMapper mapper)
    {
        _userWineRepository = userWineRepository;
        _mapper = mapper;
    }

    public async ValueTask<GetUserWinesOverviewResponse> Handle(GetUserWinesOverviewQuery request,
        CancellationToken cancellationToken)
    {
        var userWines = await _userWineRepository.GetUserWines(request.UserId);

        return new GetUserWinesOverviewResponse()
        {
            UserWines = userWines.Select(x => new GetUserWinesOverviewResponse.UserWineOverviewDto()
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