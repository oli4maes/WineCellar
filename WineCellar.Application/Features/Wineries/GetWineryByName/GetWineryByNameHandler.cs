namespace WineCellar.Application.Features.Wineries.GetWineryByName;

internal sealed class GetWineryByNameHandler : IRequestHandler<GetWineryByNameRequest, GetWineryByNameResponse>
{
    private readonly IWineryRepository _wineryRepository;

    public GetWineryByNameHandler(IWineryRepository wineryRepository)
    {
        _wineryRepository = wineryRepository;
    }

    public async ValueTask<GetWineryByNameResponse> Handle(GetWineryByNameRequest request,
        CancellationToken cancellationToken)
    {
        var winery = await _wineryRepository.GetByName(request.Name);

        if (winery is null)
        {
            return new GetWineryByNameResponse();
        }

        return new GetWineryByNameResponse()
        {
            Winery = new WineryDto()
            {
                Id = winery.Id,
                Name = winery.Name,
                CountryName = winery.Country?.Name,
                CountryId = winery.CountryId,
                Description = winery.Description
            }
        };
    }
}