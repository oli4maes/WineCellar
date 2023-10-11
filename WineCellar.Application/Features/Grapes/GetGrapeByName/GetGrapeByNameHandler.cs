using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Grapes.GetGrapeByName;

internal sealed class GetGrapeByNameHandler : IRequestHandler<GetGrapeByNameRequest, GetGrapeByNameResponse>
{
    private readonly IGrapeRepository _grapeRepository;

    public GetGrapeByNameHandler(IGrapeRepository grapeRepository)
    {
        _grapeRepository = grapeRepository;
    }

    public async ValueTask<GetGrapeByNameResponse> Handle(GetGrapeByNameRequest request,
        CancellationToken cancellationToken)
    {
        var grape = await _grapeRepository.GetByName(request.Name);

        if (grape is null)
        {
            return new GetGrapeByNameResponse();
        }
        
        return new GetGrapeByNameResponse()
        {
            Grape = new GrapeDto()
            {
                Id = grape.Id,
                Name = grape.Name,
                Description = grape.Description,
                GrapeType = grape.GrapeType
            }
        };
    }
}