namespace WineCellar.Domain.Interfaces.Repositories;

public interface IUnitOfWork
{
    IGrapeRepository Grapes { get; set; }
    IWineryRepository Wineries { get; set; }
    IWineRepository Wines { get; set; }
    IUserWineRepository UserWines { get; set; }

    Task CompleteAsync();
}