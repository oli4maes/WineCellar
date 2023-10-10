namespace WineCellar.Domain.Persistence.Repositories;

public interface IGrapeRepository
{
    Task<bool> Delete(int id);
    Task Update(Grape grape);
    Task<Grape> Create(Grape entity);
}