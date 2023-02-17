using WineCellar.Application.Features.Wines.GetWines;

namespace WineCellar.Application.Features.Wines.GetWineById;

internal sealed class GetWineByIdHandler : IRequestHandler<GetWineByIdRequest, GetWineByIdResponse>
{
    private readonly IMediator _mediator;

    public GetWineByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async ValueTask<GetWineByIdResponse> Handle(GetWineByIdRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetWinesRequest());

        return new GetWineByIdResponse()
        {
            Wine = response.Wines.FirstOrDefault(x => x.Id == request.Id)
        };
    }
}