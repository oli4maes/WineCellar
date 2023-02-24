namespace WineCellar.Application.Features.Wineries.UpdateWinery;

internal sealed class UpdateWineryHandler : IRequestHandler<UpdateWineryRequest, UpdateWineryResponse>
{
    private readonly IWineryRepository _wineryRepository;

    public UpdateWineryHandler(IWineryRepository wineryRepository)
    {
        _wineryRepository = wineryRepository;
    }

    public async ValueTask<UpdateWineryResponse> Handle(UpdateWineryRequest request, CancellationToken cancellationToken)
    {
        var winery = new Winery()
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            LastModifiedBy = request.UserName
        };

        await _wineryRepository.Update(winery);

        return new UpdateWineryResponse();
    }
}