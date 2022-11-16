namespace WineCellar.Application.Grapes.Commands.CreateGrape;

public record CreateGrapeCommand(string Name, string Description) : IRequest<Grape>;

public class CreateGrapeHandler : IRequestHandler<CreateGrapeCommand, Grape>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateGrapeHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Grape> Handle(CreateGrapeCommand request, CancellationToken cancellationToken)
    {
        var entity = new Grape();
        entity.Name = request.Name;
        entity.Description = request.Description;

        await _unitOfWork.Grapes.Create(entity);
        await _unitOfWork.CompleteAsync();

        return entity;
    }
}
