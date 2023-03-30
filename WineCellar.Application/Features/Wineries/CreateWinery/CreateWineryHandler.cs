using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wineries.CreateWinery;

internal sealed class CreateWineryHandler : IRequestHandler<CreateWineryRequest, CreateWineryResponse>
{
    private readonly IWineryRepository _wineryRepository;

    public CreateWineryHandler(IWineryRepository wineryRepository)
    {
        _wineryRepository = wineryRepository;
    }

    public async ValueTask<CreateWineryResponse> Handle(CreateWineryRequest request,
        CancellationToken cancellationToken)
    {
        var winery = new Winery()
        {
            Name = request.Name,
            Description = request.Description,
            CountryId = request.CountryId,
            CreatedBy = request.UserName
        };

        await _wineryRepository.Create(winery);

        return new CreateWineryResponse()
        {
            Winery = new WineryDto()
            {
                Id = winery.Id,
                Name = winery.Name,
                CountryId = winery.CountryId,
                Description = winery.Description
            }
        };
    }
}