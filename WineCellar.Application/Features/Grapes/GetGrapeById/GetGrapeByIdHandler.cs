using WineCellar.Application.Features.Grapes.GetGrapes;

namespace WineCellar.Application.Features.Grapes.GetGrapeById;

internal sealed class GetGrapeByIdHandler : IRequestHandler<GetGrapeByIdRequest, GetGrapeByIdResponse>
{
    private readonly IMediator _mediator;

    public GetGrapeByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async ValueTask<GetGrapeByIdResponse> Handle(GetGrapeByIdRequest request, CancellationToken cancellationToken)
    {
        var getGrapesResponse = await _mediator.Send(new GetGrapesRequest(), cancellationToken);
        var grapes = getGrapesResponse.Grapes;

        return new GetGrapeByIdResponse
        {
            Grape = grapes.FirstOrDefault(x => x.Id == request.Id)
        };
    }
}