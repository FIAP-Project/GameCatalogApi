using GameCatalogApi.Models;

namespace GameCatalogApi.Data;

public class AppDbContext
{
    public List<Game> Games { get; } = new();
    private int _nextId = 1;

    public int GetNextId() => _nextId++;
}
