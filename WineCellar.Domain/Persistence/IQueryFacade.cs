namespace WineCellar.Domain.Persistence;

public interface IQueryFacade
{
    IQueryable<Bottle> Bottles { get; }
    IQueryable<Country> Countries { get; }
    IQueryable<Grape> Grapes { get; }
    IQueryable<Region> Regions { get; }
    IQueryable<Wine> Wines { get; }
    IQueryable<Winery> Wineries { get; }
}