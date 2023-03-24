namespace WineCellar.Application.Features.Grapes.CreateGrape;

internal sealed class CreateGrapeHandler : IRequestHandler<CreateGrapeRequest, CreateGrapeResponse>
{
    private readonly IGrapeRepository _grapeRepository;

    public CreateGrapeHandler(IGrapeRepository grapeRepository)
    {
        _grapeRepository = grapeRepository;
    }

    public async ValueTask<CreateGrapeResponse> Handle(CreateGrapeRequest request, CancellationToken cancellationToken)
    {
        Grape grape = new()
        {
            Name = request.Name,
            Description = request.Description,
            CreatedBy = request.UserName,
            GrapeType = request.GrapeType
        };

        await _grapeRepository.Create(grape);

        return new CreateGrapeResponse()
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