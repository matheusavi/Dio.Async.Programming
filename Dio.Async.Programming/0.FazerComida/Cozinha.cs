namespace Dio.Async.Programming;

internal class Cozinha
{
    public void FazerComida()
    {
        CozinharArroz();
        FritarOvo();
    }

    public void CozinharArroz()
    {
        Console.Out.WriteLine("Cozinhando arroz");
        Thread.Sleep(10000);
        Console.Out.WriteLine("Arroz cozido");
    }

    public void FritarOvo()
    {
        Console.Out.WriteLine("Fritando ovo");
        Thread.Sleep(5000);
        Console.Out.WriteLine("Ovo frito");
    }

    public async Task FazerComidaAsync()
    {
        //Opção errada
        //CozinharArrozAsync();
        //FritarOvoAsync();

        //Sequencial
        //await CozinharArrozAsync();
        //await FritarOvoAsync();

        //Melhor opção
        await Task.WhenAll(CozinharArrozAsync(), FritarOvoAsync());
    }

    public async Task CozinharArrozAsync()
    {
        await Console.Out.WriteLineAsync("Cozinhando arroz");
        await Task.Delay(10000);
        await Console.Out.WriteLineAsync("Arroz cozido");
    }

    public async Task FritarOvoAsync()
    {
        await Console.Out.WriteLineAsync("Fritando ovo");
        await Task.Delay(5000);
        await Console.Out.WriteLineAsync("Ovo frito");
    }
}
