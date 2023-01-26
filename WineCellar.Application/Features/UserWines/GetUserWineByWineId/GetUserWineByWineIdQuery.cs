using WineCellar.Application.Features.UserWines.GetUserWines;

namespace WineCellar.Application.Features.UserWines.GetUserWineByWineId;

public record GetUserWineByWineIdQuery(string Auth0Id, int WineId) : IRequest<UserWineDto?>;

public sealed class GetUserWineByWineIdHandler : IRequestHandler<GetUserWineByWineIdQuery, UserWineDto?>
{
    private readonly IMediator _mediator;

    public GetUserWineByWineIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public async Task<UserWineDto?> Handle(GetUserWineByWineIdQuery request, CancellationToken cancellationToken)
    {
        List<UserWineDto> userWines = await _mediator.Send(new GetUserWinesQuery(request.Auth0Id));

        return userWines.SingleOrDefault(x => x.WineId == request.WineId);
    }
}
