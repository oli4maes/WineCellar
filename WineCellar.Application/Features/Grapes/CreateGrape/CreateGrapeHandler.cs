namespace WineCellar.Application.Features.Grapes.CreateGrape;

internal sealed class CreateGrapeHandler : IRequestHandler<CreateGrapeRequest, CreateGrapeResponse>
{
    private readonly IGrapeRepository _grapeRepository;
    private readonly IMapper _mapper;

    public CreateGrapeHandler(IGrapeRepository grapeRepository, IMapper mapper)
    {
        _grapeRepository = grapeRepository;
        _mapper = mapper;
    }

    public async ValueTask<CreateGrapeResponse> Handle(CreateGrapeRequest request, CancellationToken cancellationToken)
    {
        Grape entity = new()
        {
            Name = request.GrapeDto.Name,
            Description = request.GrapeDto.Description,
            CreatedBy = request.UserName
        };

        await _grapeRepository.Create(entity);

        return new CreateGrapeResponse()
        {
            Grape = _mapper.Map<GrapeDto>(entity)
        };
    }
}
