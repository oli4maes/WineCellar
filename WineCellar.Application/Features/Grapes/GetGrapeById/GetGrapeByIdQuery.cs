using WineCellar.Application.Features.Grapes.GetGrapes;

namespace WineCellar.Application.Features.Grapes.GetGrapeById;

public sealed record GetGrapeByIdQuery(int Id) : IRequest<GrapeDto?>;

internal sealed class GetGrapeByIdHandler : IRequestHandler<GetGrapeByIdQuery, GrapeDto?>
{
    private readonly IMediator _mediator;

    public GetGrapeByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<GrapeDto?> Handle(GetGrapeByIdQuery request, CancellationToken cancellationToken)
    {
        var results = await _mediator.Send(new GetGrapesQuery(), cancellationToken);

        return results.FirstOrDefault(x => x.Id == request.Id);
    }
}