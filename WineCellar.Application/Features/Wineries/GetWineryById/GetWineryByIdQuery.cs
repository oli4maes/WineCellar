﻿using WineCellar.Application.Features.Wineries.GetWineries;

namespace WineCellar.Application.Features.Wineries.GetWineryById;

public sealed record GetWineryByIdQuery(int Id) : IRequest<WineryDto?>;

internal sealed class GetWineryByIdHandler : IRequestHandler<GetWineryByIdQuery, WineryDto?>
{
    private readonly IMediator _mediator;

    public GetWineryByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async ValueTask<WineryDto?> Handle(GetWineryByIdQuery request, CancellationToken cancellationToken)
    {
        var results = await _mediator.Send(new GetWineriesQuery(), cancellationToken);

        return results.FirstOrDefault(x => x.Id == request.Id);
    }
}

