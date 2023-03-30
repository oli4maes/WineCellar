using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Grapes.UpdateGrape;

internal sealed class UpdateGrapeHandler : IRequestHandler<UpdateGrapeRequest, UpdateGrapeResponse>
{
    private readonly IGrapeRepository _grapeRepository;

    public UpdateGrapeHandler(IGrapeRepository grapeRepository)
    {
        _grapeRepository = grapeRepository;
    }

    public async ValueTask<UpdateGrapeResponse> Handle(UpdateGrapeRequest request, CancellationToken cancellationToken)
    {
        var grape = new Grape()
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            GrapeType = request.GrapeType,
            LastModifiedBy = request.UserName
        };

        await _grapeRepository.Update(grape);

        return new UpdateGrapeResponse();
    }
}
