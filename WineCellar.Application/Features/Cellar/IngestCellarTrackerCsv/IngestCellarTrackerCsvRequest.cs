namespace WineCellar.Application.Features.Cellar.IngestCellarTrackerCsv;

public sealed record IngestCellarTrackerCsvRequest(string FilePath) : IRequest<IngestCellarTrackerCsvResponse>;