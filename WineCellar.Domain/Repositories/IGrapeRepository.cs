namespace WineCellar.Domain.Repositories;

public interface IGrapeRepository
{
    Task<List<Grape>> GetGrapes();
    Task<Grape> GetGrapeById(int id);
    void Add(Grape grape);
    void Remove(Grape grape);
}
