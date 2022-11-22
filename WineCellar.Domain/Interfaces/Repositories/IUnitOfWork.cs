namespace WineCellar.Domain.Interfaces.Repositories;

public interface IUnitOfWork
{
    IGrapeRepository Grapes { get; set; }
    IWineryRepository Wineries { get; set; }

    Task CompleteAsync();
}