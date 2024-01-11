namespace WineCellar.Application.Features.Cellar.IngestCellarTrackerCsv;

public sealed record IngestCellarTrackerCsvRequest(string FilePath, string UserName, string Auth0Id)
    : IRequest<IngestCellarTrackerCsvResponse>;