﻿using WineCellar.Application.Grapes.Queries.GetGrapes;

namespace WineCellar.Application.Grapes.Queries.GetGrapeById;

public sealed record GetGrapeByIdQuery(int Id) : IRequest<GrapeDto>;

public sealed class GetGrapeByIdHandler : IRequestHandler<GetGrapeByIdQuery, GrapeDto>
{
    private readonly IMediator _mediator;

    public GetGrapeByIdHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<GrapeDto> Handle(GetGrapeByIdQuery request, CancellationToken cancellationToken)
    {
        var results = await _mediator.Send(new GetGrapesQuery());

        return results.FirstOrDefault(x => x.Id == request.Id);
    }
}