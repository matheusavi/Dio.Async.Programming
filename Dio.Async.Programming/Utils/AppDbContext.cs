using AutoFixture;
using Microsoft.EntityFrameworkCore;

namespace Dio.Async.Programming;

public class AppDbContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("AppDatabase");
    }

    /// <summary>
    /// Este método faz a criação de dados do banco em memória
    /// </summary>
    public void Seed()
    {
        Pessoas.RemoveRange(Pessoas);
        SaveChanges();
        var fixture = new Fixture();
        var pessoas = fixture.CreateMany<Pessoa>(5);
        Pessoas.AddRange(pessoas);
        SaveChanges();
    }
}