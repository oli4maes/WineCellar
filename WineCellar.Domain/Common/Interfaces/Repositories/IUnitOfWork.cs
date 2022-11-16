namespace WineCellar.Domain.Common.Interface.Repositories;

public interface IUnitOfWork
{
    IGrapeRepository Grapes { get; set; }

    Task CompleteAsync();
}