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

        var country = new CountryDto();

        if (winery.Country is not null)
        {
            country.Id = winery.Country.Id;
            country.Name = winery.Country.Name;
        }

        return new GetWineryByIdResponse()
        {
            Winery = new WineryDto()
            {
                Id = winery.Id,
                Name = winery.Name,
                Country = country,
                CountryName = winery.Country?.Name,
                CountryId = winery.CountryId,
                Description = winery.Description
            }
        };
    }
}