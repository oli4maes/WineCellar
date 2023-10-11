using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Grapes.GetGrapeById;

internal sealed class GetGrapeByIdHandler : IRequestHandler<GetGrapeByIdRequest, GetGrapeByIdResponse>
{
    private readonly IGrapeRepository _grapeRepository;

    public GetGrapeByIdHandler(IGrapeRepository grapeRepository)
    {
        _grapeRepository = grapeRepository;
    }

    public async ValueTask<GetGrapeByIdResponse> Handle(GetGrapeByIdRequest request,
        CancellationToken cancellationToken)
    {
        var grape = await _grapeRepository.GetById(request.Id);

        if (grape is null)
        {
            return new GetGrapeByIdResponse()
            {
                ErrorMessage = $"Couldn't find the grape with id: {request.Id}."
            };
        }

        return new GetGrapeByIdResponse
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