using WineCellar.Application.Features.Grapes.GetGrapeByName;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Grapes.CreateGrape;

internal sealed class CreateGrapeHandler : IRequestHandler<CreateGrapeRequest, CreateGrapeResponse>
{
    private readonly IMediator _mediator;
    private readonly IGrapeRepository _grapeRepository;

    public CreateGrapeHandler(IGrapeRepository grapeRepository, IMediator mediator)
    {
        _mediator = mediator;
        _grapeRepository = grapeRepository;
    }

    public async ValueTask<CreateGrapeResponse> Handle(CreateGrapeRequest request, CancellationToken cancellationToken)
    {
        var grapeByNameResponse = await _mediator.Send(new GetGrapeByNameRequest(request.Name));
        if (grapeByNameResponse.Grape != null)
        {
            return new CreateGrapeResponse()
            {
                ErrorMessage = $"The grape with name: {grapeByNameResponse.Grape.Name} already exists."
            };
        }

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