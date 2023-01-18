namespace WineCellar.Application.Features.UserWines.GetUserWines;

public sealed record GetUserWinesQuery(string UserId) : IRequest<List<UserWineDto>>;

public sealed class GetUserWinesHandler : IRequestHandler<GetUserWinesQuery, List<UserWineDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetUserWinesHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<UserWineDto>> Handle(GetUserWinesQuery request, CancellationToken cancellationToken)
    {
        var userWines = await _unitOfWork.UserWines.GetUserWines(request.UserId);

        return _mapper.Map<List<UserWineDto>>(userWines);
    }
}
