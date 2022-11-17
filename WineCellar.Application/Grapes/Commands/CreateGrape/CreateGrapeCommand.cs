﻿namespace WineCellar.Application.Grapes.Commands.CreateGrape;

public sealed record CreateGrapeCommand(string Name, string Description) : IRequest<GrapeDto>;

public sealed class CreateGrapeHandler : IRequestHandler<CreateGrapeCommand, GrapeDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateGrapeHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<GrapeDto> Handle(CreateGrapeCommand request, CancellationToken cancellationToken)
    {
        var entity = new Grape();
        entity.Name = request.Name;
        entity.Description = request.Description;

        await _unitOfWork.Grapes.Create(entity);
        await _unitOfWork.CompleteAsync();

        return _mapper.Map<GrapeDto>(entity);
    }
}
