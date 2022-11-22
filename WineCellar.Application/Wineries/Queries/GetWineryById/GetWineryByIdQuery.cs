using WineCellar.Application.Wineries.Queries.GetWineries;

namespace WineCellar.Application.Wineries.Queries.GetWineryById;

public sealed record GetWineryByIdQuery(int Id) : IRequest<WineryDto>;

public sealed class GetWineryByIdHandler : IRequestHandler<GetWineryByIdQuery, WineryDto>
{
    private readonly IMediator _mediator;

    public GetWineryByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<WineryDto> Handle(GetWineryByIdQuery request, CancellationToken cancellationToken)
    {
        var results = await _mediator.Send(new GetWineriesQuery());

        return results.FirstOrDefault(x => x.Id == request.Id);
    }
}

