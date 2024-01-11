using System.Globalization;
using CsvHelper.Configuration;

namespace WineCellar.Application.CSV;

public static class CsvConfigHelper
{
    public static CsvConfiguration GetCsvConfig()
    {
        return new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            HeaderValidated = null,
            Delimiter = ",",
            IgnoreBlankLines = false,
        };
    }
}