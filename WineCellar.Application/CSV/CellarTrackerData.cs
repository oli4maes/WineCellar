using CsvHelper.Configuration.Attributes;

namespace WineCellar.Application.CSV;

public class CellarTrackerData
{
    [Name("Type")] public string Type { get; set; }

    [Name("Color")] public string Color { get; set; }

    [Name("Category")] public string Category { get; set; }

    [Name("Size")] public string Size { get; set; }

    [Name("Currency")] public string Currency { get; set; }

    [Name("Value")] public string Value { get; set; }

    [Name("Price")] public string Price { get; set; }

    [Name("TotalQuantity")] public string TotalQuantity { get; set; }

    [Name("Quantity")] public string Quantity { get; set; }

    [Name("Pending")] public string Pending { get; set; }

    [Name("Vintage")] public string Vintage { get; set; }

    [Name("Wine")] public string Wine { get; set; }

    [Name("Locale")] public string Locale { get; set; }

    [Name("Producer")] public string Producer { get; set; }

    [Name("Varietal")] public string Varietal { get; set; }

    [Name("MasterVarietal")] public string MasterVarietal { get; set; }

    [Name("Designation")] public string Designation { get; set; }

    [Name("Vineyard")] public string Vineyard { get; set; }

    [Name("Country")] public string Country { get; set; }

    [Name("Region")] public string Region { get; set; }

    [Name("SubRegion")] public string SubRegion { get; set; }

    [Name("Appellation")] public string Appellation { get; set; }
}