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
    }

    public async Task LerDoBancoAsync()
    {
    }
}

