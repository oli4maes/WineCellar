namespace WineCellar.Application.Grapes.Queries.GetGrapes;

public record GetGrapesQuery : IRequest<List<Grape>>;

public class GetGrapesHandler : IRequestHandler<GetGrapesQuery, List<Grape>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetGrapesHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<Grape>> Handle(GetGrapesQuery request, CancellationToken cancellationToken)
    {
        var grapes = await _unitOfWork.Grapes.All();

        return grapes.ToList();
    }
}