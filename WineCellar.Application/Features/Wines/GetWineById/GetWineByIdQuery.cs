using WineCellar.Application.Features.Wines.GetWines;

namespace WineCellar.Application.Features.Wines.GetWineById;

public sealed record GetWineByIdQuery(int Id) : IRequest<WineDto?>;

public sealed class GetWineByIdHandler : IRequestHandler<GetWineByIdQuery, WineDto?>
{
    private readonly IMediator _mediator;

    public GetWineByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async ValueTask<WineDto?> Handle(GetWineByIdQuery request, CancellationToken cancellationToken)
    {
        List<WineDto> results = await _mediator.Send(new GetWinesQuery());

        return results.FirstOrDefault(x => x.Id == request.Id);
    }
}
