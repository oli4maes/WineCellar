namespace WineCellar.Application.CSV;

internal sealed class CellarTrackerCsv
{
    public IReadOnlyList<CellarTrackerData> GetResult(string filePath)
    {
        return ParseInput(filePath);
    }

    private IReadOnlyList<CellarTrackerData> ParseInput(string filePath)
    {
        using var sr = new StreamReader(new MemoryStream(filePath.Data))
    }
}