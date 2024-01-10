namespace WineCellar.Application.Features.Cellar.IngestCellarTrackerCsv;

internal sealed class
    IngestCellarTrackerCsvHandler : IRequestHandler<IngestCellarTrackerCsvRequest, IngestCellarTrackerCsvResponse>
{
    public async ValueTask<IngestCellarTrackerCsvResponse> Handle(IngestCellarTrackerCsvRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}