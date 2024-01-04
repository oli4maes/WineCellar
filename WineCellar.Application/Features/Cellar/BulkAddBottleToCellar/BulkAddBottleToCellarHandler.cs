using System.Collections.Concurrent;
using WineCellar.Application.Features.Cellar.AddBottleToCellar;

namespace WineCellar.Application.Features.Cellar.BulkAddBottleToCellar;

public class BulkAddBottleToCellarHandler : IRequestHandler<BulkAddBottleToCellarRequest, BulkAddBottleToCellarResponse>
{
    private readonly IMediator _mediator;

    public BulkAddBottleToCellarHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async ValueTask<BulkAddBottleToCellarResponse> Handle(BulkAddBottleToCellarRequest request,
        CancellationToken cancellationToken)
    {
        var failedRequests = new ConcurrentBag<AddBottleToCellarRequest>();
        var succeededRequests = new ConcurrentBag<AddBottleToCellarRequest>();

        for (var i = 0; i < request.Amount; i++)
        {
            var addBottleToCellarRequest = new AddBottleToCellarRequest(
                request.WineId, request.BottleSize, request.UserName, request.AddedOn, request.Auth0Id,
                request.PricePerBottle, request.Vintage);

            try
            {
                await _mediator.Send(addBottleToCellarRequest, cancellationToken);
                succeededRequests.Add(addBottleToCellarRequest);
            }
            catch (Exception e)
            {
                failedRequests.Add(addBottleToCellarRequest);
            }
        }

        return new BulkAddBottleToCellarResponse()
        {
            AmountSucceeded = succeededRequests.Count,
            AmountFailed = failedRequests.Count
        };
    }
}