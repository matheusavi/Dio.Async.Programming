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
        foreach (var item in pessoas)
        {
            Console.WriteLine(item);
        }
    }

    public async Task LerDoBancoAsync()
    {
        var pessoas = await _appDbContext.Pessoas.ToListAsync();
        foreach (var item in pessoas)
        {
            Console.WriteLine(item);
        }
    }
}

