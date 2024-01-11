using System.Globalization;
using System.Text;
using CsvHelper;
using WineCellar.Application.CSV;
using WineCellar.Application.Features.Cellar.BulkAddBottleToCellar;
using WineCellar.Domain.Enums;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.Features.Cellar.IngestCellarTrackerCsv;

internal sealed class
    IngestCellarTrackerCsvHandler : IRequestHandler<IngestCellarTrackerCsvRequest, IngestCellarTrackerCsvResponse>
{
    private readonly IWineryRepository _wineryRepository;
    private readonly IWineRepository _wineRepository;
    private readonly IRegionRepository _regionRepository;
    private readonly ICountryRepository _countryRepository;
    private readonly IMediator _mediator;

    public IngestCellarTrackerCsvHandler(IWineryRepository wineryRepository, IWineRepository wineRepository,
        IRegionRepository regionRepository, ICountryRepository countryRepository, IMediator mediator)
    {
        _wineryRepository = wineryRepository;
        _wineRepository = wineRepository;
        _regionRepository = regionRepository;
        _countryRepository = countryRepository;
        _mediator = mediator;
    }

    public async ValueTask<IngestCellarTrackerCsvResponse> Handle(IngestCellarTrackerCsvRequest request,
        CancellationToken cancellationToken)
    {
        if (!File.Exists(request.FilePath))
        {
            return new IngestCellarTrackerCsvResponse
            {
                Success = false
            };
        }

        using var sr = new StreamReader(request.FilePath, Encoding.Latin1);
        using var parser = new CsvReader(sr, CsvConfigHelper.GetCsvConfig());

        var data = parser.GetRecords<CellarTrackerData>().ToList();

        var regions = await _regionRepository.All();
        var countries = await _countryRepository.All();

        foreach (var line in data)
        {
            var winery = await _wineryRepository.GetByName(line.Producer);
            int wineryId;
            if (winery is null)
            {
                var wineryToCreate = new Winery
                {
                    Name = line.Producer,
                    CountryId = GetCountryId(line.Country, countries)
                };

                var createdWinery = await _wineryRepository.Create(wineryToCreate);
                wineryId = createdWinery.Id;
            }
            else
            {
                wineryId = winery.Id;
            }

            var wineId = 0;
            string wineName;
            if (line.Wine.Length <= line.Producer.Length)
            {
                wineName = line.Wine;
            }
            else
            {
                wineName = line.Wine.Substring(line.Producer.Length + 1);
            }

            var wine = await _wineRepository.GetByName(wineName);
            if (wine is null)
            {
                var wineToCreate = new Wine
                {
                    Name = wineName,
                    WineType = GetWineType(line.Type),
                    RegionId = GetRegionId(line.Region, regions),
                    WineryId = wineryId
                };

                var createdWine = await _wineRepository.Create(wineToCreate);
                wineId = createdWine.Id;
            }

            var commaCulture = new CultureInfo("en")
            {
                NumberFormat =
                {
                    NumberDecimalSeparator = ","
                }
            };

            double.TryParse(line.Price, NumberStyles.Any, commaCulture, out var price);
            int.TryParse(line.Vintage, out var vintage);
            int.TryParse(line.TotalQuantity, out var quantity);

            var response = await _mediator.Send(
                new BulkAddBottleToCellarRequest(
                    wine?.Id ?? wineId,
                    GetBottleSize(line.Size),
                    quantity,
                    DateTime.Now,
                    request.UserName,
                    request.Auth0Id,
                    price,
                    line.Vintage == "1001" ? null : vintage
                ), cancellationToken);
        }

        return new IngestCellarTrackerCsvResponse
        {
            Success = true
        };
    }

    private static WineType GetWineType(string wineType)
    {
        if (wineType.Length > 9 && wineType.Substring(wineType.Length - 9) == "Sparkling")
        {
            return WineType.Sparkling;
        }

        return wineType switch
        {
            "White" => WineType.White,
            "Rosé" => WineType.Rosé,
            "Red" => WineType.Red,
            _ => throw new Exception("Unsupported wine type")
        };
    }

    private static int? GetRegionId(string region, IEnumerable<Region> regions)
    {
        var foundRegion = regions.SingleOrDefault(x =>
            x.Name.Contains(region, StringComparison.OrdinalIgnoreCase));
        return foundRegion?.Id;
    }

    private static int GetCountryId(string country, IEnumerable<Country> countries)
    {
        if (country == "USA")
        {
            var usa = countries.Single(x => x.Name == "United States");
            return usa.Id;
        }

        var foundCountry = countries.Single(x =>
            x.Name.Contains(country, StringComparison.OrdinalIgnoreCase));
        return foundCountry.Id;
    }

    private static BottleSize GetBottleSize(string bottleSize)
    {
        return bottleSize switch
        {
            "750ml" => BottleSize.Standard,
            "375ml" => BottleSize.Demie,
            "1500ml" => BottleSize.Magnum,
            "3000ml" => BottleSize.DoubleMagnum,
            "4500ml" => BottleSize.Jeroboam,
            "6000ml" => BottleSize.Imperial,
            "9000ml" => BottleSize.Salamanzar,
            "12000ml" => BottleSize.Balthazar,
            "15000ml" => BottleSize.Nebuchadnezzar,
            _ => throw new Exception("Unsupported bottle size")
        };
    }
}