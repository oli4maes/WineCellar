namespace WineCellar.Application.Features.Grapes.CreateGrape;

public sealed record CreateGrapeCommand(GrapeDto GrapeDto, string UserName) : IRequest<GrapeDto>;

public sealed class CreateGrapeHandler : IRequestHandler<CreateGrapeCommand, GrapeDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateGrapeHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
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

        await _unitOfWork.Grapes.Create(entity);
        await _unitOfWork.CompleteAsync();

        return _mapper.Map<GrapeDto>(entity);
    }
}
