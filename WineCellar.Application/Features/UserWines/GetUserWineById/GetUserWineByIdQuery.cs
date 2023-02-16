using WineCellar.Application.Features.UserWines.GetUserWines;

namespace WineCellar.Application.Features.UserWines.GetUserWineById;

public sealed record GetUserWineByIdQuery(int Id, string UserId) : IRequest<UserWineDto?>;

internal sealed class GetUserWineByIdHandler : IRequestHandler<GetUserWineByIdQuery, UserWineDto?>
{
    private readonly IMediator _mediator;

    public GetUserWineByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public async ValueTask<UserWineDto?> Handle(GetUserWineByIdQuery request, CancellationToken cancellationToken)
    {
        var results = await _mediator.Send(new GetUserWinesQuery(request.UserId), cancellationToken);

        return results.FirstOrDefault(x => x.Id == request.Id);
    }
}