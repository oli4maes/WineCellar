namespace WineCellar.Application.Features.Wineries.GetWineryById;

internal sealed class GetWineryByIdHandler : IRequestHandler<GetWineryByIdRequest, GetWineryByIdResponse>
{
    private readonly IWineryRepository _wineryRepository;

    public GetWineryByIdHandler(IWineryRepository wineryRepository)
    {
        _wineryRepository = wineryRepository;
    }

    public async ValueTask<GetWineryByIdResponse> Handle(GetWineryByIdRequest request,
        CancellationToken cancellationToken)
    {
        var winery = await _wineryRepository.GetById(request.Id);

        if (winery is null)
        {
            return new GetWineryByIdResponse()
            {
                ErrorMessage = $"Couldn't find the winery with id: {request.Id}."
            };
        }

        return new GetWineryByIdResponse()
        {
            Winery = new WineryDto()
            {
                Id = winery.Id,
                Name = winery.Name,
                Description = winery.Description
            }
        };
    }
}