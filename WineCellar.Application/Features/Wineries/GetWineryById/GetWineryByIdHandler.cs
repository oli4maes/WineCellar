using WineCellar.Application.Features.Wineries.GetWineries;

namespace WineCellar.Application.Features.Wineries.GetWineryById;

internal sealed class GetWineryByIdHandler : IRequestHandler<GetWineryByIdRequest, GetWineryByIdResponse>
{
    private readonly IMediator _mediator;

    public GetWineryByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async ValueTask<GetWineryByIdResponse> Handle(GetWineryByIdRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetWineriesRequest(), cancellationToken);

        return new GetWineryByIdResponse()
        {
            Winery = response.Wineries.FirstOrDefault(x => x.Id == request.Id)
        };
    }
}