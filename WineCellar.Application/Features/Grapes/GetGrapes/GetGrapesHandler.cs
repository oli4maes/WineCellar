namespace WineCellar.Application.Features.Grapes.GetGrapes;

internal sealed class GetGrapesHandler : IRequestHandler<GetGrapesRequest, GetGrapesResponse>
{
    private readonly IGrapeRepository _grapeRepository;

    public GetGrapesHandler(IGrapeRepository grapeRepository)
    {
        _grapeRepository = grapeRepository;
    }

    public async ValueTask<GetGrapesResponse> Handle(GetGrapesRequest request, CancellationToken cancellationToken)
    {
        var grapes = await _grapeRepository.All();

        return new GetGrapesResponse()
        {
            Grapes = grapes.Select(x => new GrapeDto()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                GrapeType = x.GrapeType
            }).ToList()
        };
    }
}