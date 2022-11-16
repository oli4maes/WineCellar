namespace WineCellar.Application.Grapes.Commands.CreateGrape;

public record CreateGrapeCommand(string Name, string Description) : IRequest<Grape>;

public class CreateGrapeHandler : IRequestHandler<CreateGrapeCommand, Grape>
{
    private readonly IGrapeRepository _grapeRepository;

    public CreateGrapeHandler(IGrapeRepository grapeRepository)
    {
        _grapeRepository = grapeRepository;
    }

    public async Task<Grape> Handle(CreateGrapeCommand request, CancellationToken cancellationToken)
    {
        var entity = new Grape();
        entity.Name = request.Name;
        entity.Description = request.Description;

        _grapeRepository.Add(entity);

        return entity;
    }
}
