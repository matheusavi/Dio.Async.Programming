using Microsoft.EntityFrameworkCore;

namespace Dio.Async.Programming;

public class InteragindoComBanco
{
    private AppDbContext _appDbContext;
    public InteragindoComBanco()
    {
        _appDbContext = new AppDbContext();
        _appDbContext.Database.EnsureCreated();
        _appDbContext.Seed();
    }

    public void LerDoBanco()
    {
        var pessoas = _appDbContext.Pessoas.ToList();
        Console.WriteLine();
    }

    public async Task LerDoBancoAsync()
    {
        using var db = new AppDbContext();
        var pessoas = await _appDbContext.Pessoas.ToListAsync();
    }
}

