namespace WineCellar.Application.Features.Grapes.CreateGrape;

public sealed record CreateGrapeCommand(GrapeDto GrapeDto, string UserName) : IRequest<GrapeDto>;

internal sealed class CreateGrapeHandler : IRequestHandler<CreateGrapeCommand, GrapeDto>
{
    private readonly IGrapeRepository _grapeRepository;
    private readonly IMapper _mapper;

    public CreateGrapeHandler(IGrapeRepository grapeRepository, IMapper mapper)
    {
        _grapeRepository = grapeRepository;
        _mapper = mapper;
    }

    public async ValueTask<GrapeDto> Handle(CreateGrapeCommand request, CancellationToken cancellationToken)
    {
        Grape entity = new()
        {
            Name = request.GrapeDto.Name,
            Description = request.GrapeDto.Description,
            CreatedBy = request.UserName
        };

        await _grapeRepository.Create(entity);

        return _mapper.Map<GrapeDto>(entity);
    }
}
