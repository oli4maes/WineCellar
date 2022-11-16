using WineCellar.Domain.Repositories;

namespace WineCellar.Application.Grapes.Queries.GetGrapes;

public record GetGrapesQuery : IRequest<List<Grape>>;

public class GetGrapesHandler : IRequestHandler<GetGrapesQuery, List<Grape>>
{
    private readonly IGrapeRepository _grapeRepository;

    public GetGrapesHandler(IGrapeRepository grapeRepository)
    {
        _grapeRepository = grapeRepository;
    }

    public Task<List<Grape>> Handle(GetGrapesQuery request, CancellationToken cancellationToken)
    {
        return _grapeRepository.GetGrapes();
    }
}