namespace WineCellar.Domain.Persistence.Repositories;

public interface IGrapeRepository
{
    Task<bool> Delete(int id);
    Task Update(Grape grape);
    Task<Grape> Create(Grape entity);
    Task<List<Grape>> All();
    Task<Grape?> GetById(int id);
    Task<Grape?> GetByName(string name);
}
