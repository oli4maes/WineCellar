using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wineries.GetWineries;

internal sealed class GetWineriesHandler : IRequestHandler<GetWineriesRequest, GetWineriesResponse>
{
    private readonly IWineryRepository _wineryRepository;

    public GetWineriesHandler(IWineryRepository wineryRepository)
    {
        _wineryRepository = wineryRepository;
    }

    public async ValueTask<GetWineriesResponse> Handle(GetWineriesRequest request, CancellationToken cancellationToken)
    {
        var wineries = await _wineryRepository.All();

        return new GetWineriesResponse()
        {
            Wineries = wineries.Select(x => new WineryDto()
            {
                Id = x.Id,
                Name = x.Name,
                CountryId = x.CountryId,
                CountryName = x.Country?.Name,
                Description = x.Description
            }).ToList()
        };
    }
}