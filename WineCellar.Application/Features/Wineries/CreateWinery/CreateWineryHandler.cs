using WineCellar.Application.Features.Wineries.GetWineryByName;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Wineries.CreateWinery;

internal sealed class CreateWineryHandler : IRequestHandler<CreateWineryRequest, CreateWineryResponse>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IMediator _mediator;

    public CreateWineryHandler(IWineryRepository wineryRepository, IMediator mediator)
    {
        _wineryRepository = wineryRepository;
        _mediator = mediator;
    }

    public async ValueTask<CreateWineryResponse> Handle(CreateWineryRequest request,
        CancellationToken cancellationToken)
    {
        var getWineryByNameResponse = await _mediator.Send(new GetWineryByNameRequest(request.Name));
        if (getWineryByNameResponse.Winery != null)
        {
            return new CreateWineryResponse()
            {
                ErrorMessage = $"The winery with name: {getWineryByNameResponse.Winery.Name} already exists."
            };
        }
        
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