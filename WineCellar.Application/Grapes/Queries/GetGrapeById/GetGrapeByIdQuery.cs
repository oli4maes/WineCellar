using WineCellar.Application.Grapes.Queries.GetGrapes;

namespace WineCellar.Application.Grapes.Queries.GetGrapeById;

public record GetGrapeByIdQuery(int id) : IRequest<Grape>;

public class GetGrapeByIdHandler : IRequestHandler<GetGrapeByIdQuery, Grape>
{
    private readonly IMediator _mediator;

    public GetGrapeByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<Grape> Handle(GetGrapeByIdQuery request, CancellationToken cancellationToken)
    {
        var results = await _mediator.Send(new GetGrapesQuery());

        var output = results.FirstOrDefault(x => x.Id == request.id);

        return output;
    }
}